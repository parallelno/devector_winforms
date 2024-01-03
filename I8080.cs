using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;

namespace devector
{
	public class I8080
	{
		public UInt64 cc; // clock cycles
		public UInt16 pc, sp; // program counter, stack pointer
		public byte a, b, c, d, e, h, l; // registers

		// flags:
		public bool flag_s;		// sign
		public bool flag_z;		// zero
		public bool flag_ac;	// auxiliary carry (half-carry)
		public bool flag_p;		// parity
		public bool flag_c;		// carry
		public bool unused_flaf_1; // unused, always 1 in Vector06c
		public bool unused_flaf_3; // unused, always 0 in Vector06c
		public bool unused_flaf_5; // unused, always 0 in Vector06c

		// interruption
		public bool iff; // iterrupt flip-flop
		public bool HLTA; // indicates that HLT instruction is executed
		public byte int_pending_instructions; // a number of instructions to execute before an interruption call
		static byte OPCODE_RST7 = 0xff;

		// memory + io interface
		public delegate byte MemoryReadDelegate(int address, bool addr_space_global = false);
		public delegate void MemoryWriteDelegate(int address, byte value, bool addr_space_global = false);
		public delegate byte InputDelegate(byte port);
		public delegate void OutputDelegate(byte port, byte value);

		MemoryReadDelegate memory_read;
		MemoryWriteDelegate memory_write;
		InputDelegate input;
		OutputDelegate output;

		public I8080(
			MemoryReadDelegate _memory_read,
			MemoryWriteDelegate _memory_set,
			InputDelegate _input,
			OutputDelegate _output)
		{
			memory_read = _memory_read;
			memory_write = _memory_set;
			input = _input;
			output = _output;

			unused_flaf_1 = true;
			unused_flaf_3 = false;
			unused_flaf_5 = false;

			init();
		}

		public void init()
		{
			cc = pc = sp = 0;
			a = b = c = d = e = h = l = 0;
			flag_s = flag_z = flag_ac = flag_p = flag_c = iff = false;

			HLTA = false;
			int_pending_instructions = 0;
		}
		// executes one instruction
		public void step() {
			// interrupt processing: if an interrupt is pending and IFF is set,
			// we execute the interrupt vector passed by the user.
			if (iff && int_pending_instructions == 0)
			{
				iff = false;
				HLTA = false;
				execute(OPCODE_RST7);
			}
			else if (!HLTA)
			{
				execute(read_byte_move_pc());
			}
		}

		// this array defines the number of cycles one opcode takes.
		// TODO: this is for i8080. Update it to match Vector06c instruction cc table
		static readonly byte[] I8080_OPCODES_CYCLES = new byte[] {
			//  0  1   2   3   4   5   6   7   8  9   A   B   C   D   E  F
			4, 10, 7,  5,  5,  5,  7,  4,  4, 10, 7,  5,  5,  5,  7, 4,  // 0
			4, 10, 7,  5,  5,  5,  7,  4,  4, 10, 7,  5,  5,  5,  7, 4,  // 1
			4, 10, 16, 5,  5,  5,  7,  4,  4, 10, 16, 5,  5,  5,  7, 4,  // 2
			4, 10, 13, 5,  10, 10, 10, 4,  4, 10, 13, 5,  5,  5,  7, 4,  // 3
			5, 5,  5,  5,  5,  5,  7,  5,  5, 5,  5,  5,  5,  5,  7, 5,  // 4
			5, 5,  5,  5,  5,  5,  7,  5,  5, 5,  5,  5,  5,  5,  7, 5,  // 5
			5, 5,  5,  5,  5,  5,  7,  5,  5, 5,  5,  5,  5,  5,  7, 5,  // 6
			7, 7,  7,  7,  7,  7,  7,  7,  5, 5,  5,  5,  5,  5,  7, 5,  // 7
			4, 4,  4,  4,  4,  4,  7,  4,  4, 4,  4,  4,  4,  4,  7, 4,  // 8
			4, 4,  4,  4,  4,  4,  7,  4,  4, 4,  4,  4,  4,  4,  7, 4,  // 9
			4, 4,  4,  4,  4,  4,  7,  4,  4, 4,  4,  4,  4,  4,  7, 4,  // A
			4, 4,  4,  4,  4,  4,  7,  4,  4, 4,  4,  4,  4,  4,  7, 4,  // B
			5, 10, 10, 10, 11, 11, 7,  11, 5, 10, 10, 10, 11, 17, 7, 11, // C
			5, 10, 10, 10, 11, 11, 7,  11, 5, 10, 10, 10, 11, 17, 7, 11, // D
			5, 10, 10, 18, 11, 11, 7,  11, 5, 5,  10, 4,  11, 17, 7, 11, // E
			5, 10, 10, 4,  11, 11, 7,  11, 5, 5,  10, 4,  11, 17, 7, 11  // F
		};

		//===============================================================================
		//
		// memory helpers
		//
		//===============================================================================

		byte read_byte(UInt16 addr)
		{
			return memory_read(addr);
		}

		void write_byte(UInt16 addr, byte val)
		{
			memory_write(addr, val);
		}

		UInt16 read_word(UInt16 addr)
		{
			return (UInt16)(memory_read((UInt16)(addr + 1)) << 8 | memory_read(addr));
		}

		void write_word(UInt16 addr, UInt16 val)
		{
			memory_write(addr, (byte)(val & 0xFF));
			memory_write((UInt16)(addr + 1), (byte)(val >> 8));
		}

		// returns the next byte in memory, then increments the program counter
		byte read_byte_move_pc()
		{
			var result = read_byte(pc);
			pc++;
			return result;
		}

		// returns the next word in memory, then increments the program counter
		UInt16 read_word_move_pc()
		{
			UInt16 result = read_word(pc);
			pc += 2;
			return result;
		}

		//===============================================================================
		//
		// registers helpers
		//
		//===============================================================================

		public UInt16 i8080_get_af()
		{
			// note: bit 3 and 5 are always 0
			int psw = 0;
			psw |= flag_s ? 1 << 7 : 0;
			psw |= flag_z ? 1 << 6 : 0;
			psw |= flag_ac ? 1 << 4 : 0;
			psw |= flag_p ? 1 << 2 : 0;
			psw |= flag_c ? 1 << 0 : 0;

			psw |= unused_flaf_1 ? 1 << 1 : 0;
			psw |= unused_flaf_3 ? 1 << 1 : 0;
			psw |= unused_flaf_5 ? 1 << 1 : 0;
			return (UInt16)(a << 8 | psw);
		}
		public void i8080_set_psw(UInt16 af)
		{
			a = (byte)(af >> 8);
			byte psw = (byte)(af & 0xFF);

			flag_s = ((psw >> 7) & 1) == 1;
			flag_z = ((psw >> 6) & 1) == 1;
			flag_ac = ((psw >> 4) & 1) == 1;
			flag_p = ((psw >> 2) & 1) == 1;
			flag_c = ((psw >> 0) & 1) == 1;

			unused_flaf_1 = true;
			unused_flaf_3 = false;
			unused_flaf_5 = false;
		}

		public UInt16 i8080_get_bc() => (UInt16)((b << 8) | c);

		public void i8080_set_bc(UInt16 val)
		{
			b = (byte)(val >> 8);
			c = (byte)(val & 0xFF);
		}

		public UInt16 i8080_get_de() => (UInt16)((d << 8) | e);

		public void i8080_set_de(UInt16 val)
		{
			d = (byte)(val >> 8);
			e = (byte)(val & 0xFF);
		}

		public UInt16 i8080_get_hl() => (UInt16)((h << 8) | l);

		public void i8080_set_hl(UInt16 val)
		{
			h = (byte)(val >> 8);
			l = (byte)(val & 0xFF);
		}

		//===============================================================================
		//
		// stack helpers
		//
		//===============================================================================

		// pushes a value into the stack and updates the stack pointer
		void i8080_push_stack(UInt16 val)
		{
			sp -= 2;
			write_word(sp, val);
		}

		// pops a value from the stack and updates the stack pointer
		UInt16 i8080_pop_stack()
		{
			UInt16 val = read_word(sp);
			sp += 2;
			return val;
		}

		//===============================================================================
		//
		// opcodes
		//
		//===============================================================================

		void set_z_s_p(byte val)
		{
			flag_z = val == 0;
			flag_s = (val >> 7) == 1;
			flag_p = get_parity(val);
		}

        static readonly bool[] parity_table = new bool[]
		{
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false,
			true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true,
		};
		// returns the parity of a byte: 0 if a number of set bits of `val` is odd, else 1
		bool get_parity(byte val)
		{
			/*
			byte nb_one_bits = 0;
			for (int i = 0; i < 8; i++)
			{
				nb_one_bits += (byte)((val >> i) & 1);
			}

			return (nb_one_bits & 1) == 0;
			*/
			return parity_table[val];

        }
		// determines if there was a carry between bit 'bit_no' and 'bit_no - 1' during the calculation of 'a + b + cy'.
		bool get_carry(int bit_no, byte a, byte b, bool cy)
		{
			int result = a + b + (cy ? 1 : 0);
			int carry = result ^ a ^ b;
			return (carry & (1 << bit_no)) != 0;
		}

		// adds a value (+ an optional carry flag) to a register
		void add(ref byte reg, byte val, bool _cy)
		{
			byte result = (byte)(reg + val + (_cy ? 1 : 0));
			flag_c = get_carry(8, reg, val, _cy);
			flag_ac = get_carry(4, reg, val, _cy);
			set_z_s_p(result);
			reg = result;
		}

		// substracts a byte (+ an optional carry flag) from a register
		// see https://stackoverflow.com/a/8037485
		void sub(ref byte reg, byte val, bool cy)
		{
			add(ref reg, (byte)(~val), !cy);
			flag_c = !flag_c;
		}

		// adds a word to HL
		void dad(UInt16 val)
		{
			flag_c = (i8080_get_hl() + val) >> 16 == 1;
			i8080_set_hl((UInt16)(i8080_get_hl() + val));
		}

		// increments a byte
		byte inr(byte val)
		{
			byte result = (byte)(val + 1);
			flag_ac = (result & 0xF) == 0;
			set_z_s_p(result);
			return result;
		}

		// decrements a byte
		byte dcr(byte val)
		{
			byte result = (byte)(val - 1);
			flag_ac = !((result & 0xF) == 0xF);
			set_z_s_p(result);
			return result;
		}

		// executes a logic "and" between register A and a byte, then stores the
		// result in register A
		void ana(byte val)
		{
			byte result = (byte)(a & val);
			flag_c = false;
			flag_ac = ((a | val) & 0x08) != 0;
			set_z_s_p(result);
			a = result;
		}

		// executes a logic "xor" between register A and a byte, then stores the
		// result in register A
		void xra(byte val)
		{
			a ^= val;
			flag_c = false;
			flag_ac = false;
			set_z_s_p(a);
		}

		// executes a logic "or" between register A and a byte, then stores the
		// result in register A
		void ora(byte val)
		{
			a |= val;
			flag_c = false;
			flag_ac = false;
			set_z_s_p(a);
		}

		// compares the register A to another byte
		void cmp(byte val)
		{
			// TODO: reuse the code from i8080_sub
			UInt16 result = (UInt16)(a - val);
			flag_c = result >> 8 == 1;
			flag_ac = (~(a ^ result ^ val) & 0x10) == 0x10;
			set_z_s_p((byte)(result & 0xFF));
		}

		// if a condition is met, it jumps to the next address
		// pointed by the next word in memory 
		void jmp_cond(bool condition)
		{
			UInt16 addr = read_word_move_pc();
			if (condition)
			{
				pc = addr;
			}
		}

		// pushes the current pc to the stack, then jumps to an address
		void call(UInt16 addr)
		{
			i8080_push_stack(pc);
			pc = addr;
		}

		// calls to next word in memory if a condition is met
		void call_cond(bool condition)
		{
			UInt16 addr = read_word_move_pc();
			if (condition)
			{
				call(addr);
				cc += 6;
			}
		}

		// returns from subroutine
		void ret()
		{
			pc = i8080_pop_stack();
		}

		// returns from subroutine if a condition is met
		void ret_cond(bool condition)
		{
			if (condition)
			{
				ret();
				cc += 6;
			}
		}

		// rotate register A left
		void rlc()
		{
			flag_c = a >> 7 == 1;
			a = (byte)(a << 1);
			a += (byte)(flag_c ? 1 : 0);
		}

		// rotate register A right
		void rrc()
		{
			flag_c = (a & 1) == 1;
			a = (byte)(a >> 1);
			a |= (byte)(flag_c ? 1 << 7: 0);
		}

		// rotate register A left with the carry flag
		void ral()
		{
			bool cy = flag_c;
			flag_c = a >> 7 == 1;
			a = (byte)(a << 1);
			a |= (byte)(cy ? 1 : 0);
		}

		// rotate register A right with the carry flag
		void rar()
		{
			bool cy = flag_c;
			flag_c = (a & 1) == 1;
			a = (byte)(a >> 1);
			a |= (byte)(cy ? 1 << 7 : 0);
		}

		// Decimal Adjust Accumulator: the eight-bit number in register A is adjusted
		// to form two four-bit binary-coded-decimal digits.
		// For example, if A=$2B and DAA is executed, A becomes $31.
		void daa()
		{
			bool cy = flag_c;
			byte correction = 0;

			byte lsb = (byte)(a & 0x0F);
			byte msb = (byte)(a >> 4);

			if (flag_ac || lsb > 9)
			{
				correction += 0x06;
			}

			if (flag_c || msb > 9 || (msb >= 9 && lsb > 9))
			{
				correction += 0x60;
				cy = true;
			}

			add(ref a, correction, false);
			flag_c = cy;
		}

		// switches the value of registers DE and HL
		void xchg()
		{
			UInt16 de = i8080_get_de();
			i8080_set_de(i8080_get_hl());
			i8080_set_hl(de);
		}

		// switches the value of a word at (sp) and HL
		void xthl()
		{
			UInt16 val = read_word(sp);
			write_word(sp, i8080_get_hl());
			i8080_set_hl(val);
		}


		// executes one opcode
		void execute(byte opcode)
			{
				cc += I8080_OPCODES_CYCLES[opcode];

				// when DI is executed, interrupts won't be serviced
				// until the end of next instruction:
				int_pending_instructions = (byte)(int_pending_instructions > 0 ? int_pending_instructions - 1 : 0);

				switch (opcode) 
				{
					case 0x7F: a = a; break; // MOV A,A
					case 0x78: a = b; break; // MOV A,B
					case 0x79: a = c; break; // MOV A,C
					case 0x7A: a = d; break; // MOV A,D
					case 0x7B: a = e; break; // MOV A,E
					case 0x7C: a = h; break; // MOV A,H
					case 0x7D: a = l; break; // MOV A,L
					case 0x7E: a = read_byte(i8080_get_hl()); break; // MOV A,M

					case 0x0A: a = read_byte(i8080_get_bc()); break; // LDAX B
					case 0x1A: a = read_byte(i8080_get_de()); break; // LDAX D
					case 0x3A: a = read_byte(read_word_move_pc()); break; // LDA word

					case 0x47: b = a; break; // MOV B,A
					case 0x40: b = b; break; // MOV B,B
					case 0x41: b = c; break; // MOV B,C
					case 0x42: b = d; break; // MOV B,D
					case 0x43: b = e; break; // MOV B,E
					case 0x44: b = h; break; // MOV B,H
					case 0x45: b = l; break; // MOV B,L
					case 0x46: b = read_byte(i8080_get_hl()); break; // MOV B,M

					case 0x4F: c = a; break; // MOV C,A
					case 0x48: c = b; break; // MOV C,B
					case 0x49: c = c; break; // MOV C,C
					case 0x4A: c = d; break; // MOV C,D
					case 0x4B: c = e; break; // MOV C,E
					case 0x4C: c = h; break; // MOV C,H
					case 0x4D: c = l; break; // MOV C,L
					case 0x4E: c = read_byte(i8080_get_hl()); break; // MOV C,M

					case 0x57: d = a; break; // MOV D,A
					case 0x50: d = b; break; // MOV D,B
					case 0x51: d = c; break; // MOV D,C
					case 0x52: d = d; break; // MOV D,D
					case 0x53: d = e; break; // MOV D,E
					case 0x54: d = h; break; // MOV D,H
					case 0x55: d = l; break; // MOV D,L
					case 0x56: d = read_byte(i8080_get_hl()); break; // MOV D,M

					case 0x5F: e = a; break; // MOV E,A
					case 0x58: e = b; break; // MOV E,B
					case 0x59: e = c; break; // MOV E,C
					case 0x5A: e = d; break; // MOV E,D
					case 0x5B: e = e; break; // MOV E,E
					case 0x5C: e = h; break; // MOV E,H
					case 0x5D: e = l; break; // MOV E,L
					case 0x5E: e = read_byte(i8080_get_hl()); break; // MOV E,M

					case 0x67: h = a; break; // MOV H,A
					case 0x60: h = b; break; // MOV H,B
					case 0x61: h = c; break; // MOV H,C
					case 0x62: h = d; break; // MOV H,D
					case 0x63: h = e; break; // MOV H,E
					case 0x64: h = h; break; // MOV H,H
					case 0x65: h = l; break; // MOV H,L
					case 0x66: h = read_byte(i8080_get_hl()); break; // MOV H,M

					case 0x6F: l = a; break; // MOV L,A
					case 0x68: l = b; break; // MOV L,B
					case 0x69: l = c; break; // MOV L,C
					case 0x6A: l = d; break; // MOV L,D
					case 0x6B: l = e; break; // MOV L,E
					case 0x6C: l = h; break; // MOV L,H
					case 0x6D: l = l; break; // MOV L,L
					case 0x6E: l = read_byte(i8080_get_hl()); break; // MOV L,M

					case 0x77: write_byte(i8080_get_hl(), a); break; // MOV M,A
					case 0x70: write_byte(i8080_get_hl(), b); break; // MOV M,B
					case 0x71: write_byte(i8080_get_hl(), c); break; // MOV M,C
					case 0x72: write_byte(i8080_get_hl(), d); break; // MOV M,D
					case 0x73: write_byte(i8080_get_hl(), e); break; // MOV M,E
					case 0x74: write_byte(i8080_get_hl(), h); break; // MOV M,H
					case 0x75: write_byte(i8080_get_hl(), l); break; // MOV M,L

					case 0x3E: a = read_byte_move_pc(); break; // MVI A,byte
					case 0x06: b = read_byte_move_pc(); break; // MVI B,byte
					case 0x0E: c = read_byte_move_pc(); break; // MVI C,byte
					case 0x16: d = read_byte_move_pc(); break; // MVI D,byte
					case 0x1E: e = read_byte_move_pc(); break; // MVI E,byte
					case 0x26: h = read_byte_move_pc(); break; // MVI H,byte
					case 0x2E: l = read_byte_move_pc(); break; // MVI L,byte
					case 0x36: write_byte(i8080_get_hl(), read_byte_move_pc()); break; // MVI M,byte

					case 0x02: write_byte(i8080_get_bc(), a); break; // STAX B
					case 0x12: write_byte(i8080_get_de(), a); break; // STAX D
					case 0x32: write_byte(read_word_move_pc(), a); break; // STA word

					case 0x01: i8080_set_bc(read_word_move_pc()); break; // LXI B,word
					case 0x11: i8080_set_de(read_word_move_pc()); break; // LXI D,word
					case 0x21: i8080_set_hl(read_word_move_pc()); break; // LXI H,word
					case 0x31: sp = read_word_move_pc(); break; // LXI SP,word
					case 0x2A: i8080_set_hl(read_word(read_word_move_pc())); break; // LHLD
					case 0x22: write_word(read_word_move_pc(), i8080_get_hl()); break; // SHLD
					case 0xF9: sp = i8080_get_hl(); break; // SPHL

					case 0xEB: xchg(); break; // XCHG
					case 0xE3: xthl(); break; // XTHL

					case 0x87: add(ref a, a, false); break; // ADD A
					case 0x80: add(ref a, b, false); break; // ADD B
					case 0x81: add(ref a, c, false); break; // ADD C
					case 0x82: add(ref a, d, false); break; // ADD D
					case 0x83: add(ref a, e, false); break; // ADD E
					case 0x84: add(ref a, h, false); break; // ADD H
					case 0x85: add(ref a, l, false); break; // ADD L
					case 0x86: add(ref a, read_byte(i8080_get_hl()), false); break; // ADD M
					case 0xC6: add(ref a, read_byte_move_pc(), false); break; // ADI byte

					case 0x8F: add(ref a, a, flag_c); break; // ADC A
					case 0x88: add(ref a, b, flag_c); break; // ADC B
					case 0x89: add(ref a, c, flag_c); break; // ADC C
					case 0x8A: add(ref a, d, flag_c); break; // ADC D
					case 0x8B: add(ref a, e, flag_c); break; // ADC E
					case 0x8C: add(ref a, h, flag_c); break; // ADC H
					case 0x8D: add(ref a, l, flag_c); break; // ADC L
					case 0x8E: add(ref a, read_byte(i8080_get_hl()), flag_c); break; // ADC M
					case 0xCE: add(ref a, read_byte_move_pc(), flag_c); break; // ACI byte

					case 0x97: sub(ref a, a, false); break; // SUB A
					case 0x90: sub(ref a, b, false); break; // SUB B
					case 0x91: sub(ref a, c, false); break; // SUB C
					case 0x92: sub(ref a, d, false); break; // SUB D
					case 0x93: sub(ref a, e, false); break; // SUB E
					case 0x94: sub(ref a, h, false); break; // SUB H
					case 0x95: sub(ref a, l, false); break; // SUB L
					case 0x96: sub(ref a, read_byte(i8080_get_hl()), false); break; // SUB M
					case 0xD6: sub(ref a, read_byte_move_pc(), false); break; // SUI byte

					case 0x9F: sub(ref a, a, flag_c); break; // SBB A
					case 0x98: sub(ref a, b, flag_c); break; // SBB B
					case 0x99: sub(ref a, c, flag_c); break; // SBB C
					case 0x9A: sub(ref a, d, flag_c); break; // SBB D
					case 0x9B: sub(ref a, e, flag_c); break; // SBB E
					case 0x9C: sub(ref a, h, flag_c); break; // SBB H
					case 0x9D: sub(ref a, l, flag_c); break; // SBB L
					case 0x9E: sub(ref a, read_byte(i8080_get_hl()), flag_c); break; // SBB M
					case 0xDE: sub(ref a, read_byte_move_pc(), flag_c); break; // SBI byte

					case 0x09: dad(i8080_get_bc()); break; // DAD B
					case 0x19: dad(i8080_get_de()); break; // DAD D
					case 0x29: dad(i8080_get_hl()); break; // DAD H
					case 0x39: dad(sp); break; // DAD SP

					case 0xF3: iff = false; break; // DI
					case 0xFB:
						iff = true;
						int_pending_instructions = 1;
						break; // EI
					case 0x00: break; // NOP
					case 0x76: HLTA = true; break; // HLT

					case 0x3C: a = inr(a); break; // INR A
					case 0x04: b = inr(b); break; // INR B
					case 0x0C: c = inr(c); break; // INR C
					case 0x14: d = inr(d); break; // INR D
					case 0x1C: e = inr(e); break; // INR E
					case 0x24: h = inr(h); break; // INR H
					case 0x2C: l = inr(l); break; // INR L
					case 0x34: write_byte(i8080_get_hl(), inr(read_byte(i8080_get_hl()))); break; // INR M

					case 0x3D: a = dcr(a); break; // DCR A
					case 0x05: b = dcr(b); break; // DCR B
					case 0x0D: c = dcr(c); break; // DCR C
					case 0x15: d = dcr(d); break; // DCR D
					case 0x1D: e = dcr(e); break; // DCR E
					case 0x25: h = dcr(h); break; // DCR H
					case 0x2D: l = dcr(l); break; // DCR L
					case 0x35: write_byte(i8080_get_hl(), dcr(read_byte(i8080_get_hl()))); break; // DCR M

					case 0x03: i8080_set_bc((UInt16)(i8080_get_bc() + 1)); break; // INX B
					case 0x13: i8080_set_de((UInt16)(i8080_get_de() + 1)); break; // INX D
					case 0x23: i8080_set_hl((UInt16)(i8080_get_hl() + 1)); break; // INX H
					case 0x33: sp += 1; break; // INX SP

					case 0x0B: i8080_set_bc((UInt16)(i8080_get_bc() - 1)); break; // DCX B
					case 0x1B: i8080_set_de((UInt16)(i8080_get_de() - 1)); break; // DCX D
					case 0x2B: i8080_set_hl((UInt16)(i8080_get_hl() - 1)); break; // DCX H
					case 0x3B: sp -= 1; break; // DCX SP

					case 0x27: daa(); break; // DAA
					case 0x2F: a = (byte)(~a); break; // CMA
					case 0x37: flag_c = true; break; // STC
					case 0x3F: flag_c = !flag_c; break; // CMC

					case 0x07: rlc(); break; // RLC (rotate left)
					case 0x0F: rrc(); break; // RRC (rotate right)
					case 0x17: ral(); break; // RAL
					case 0x1F: rar(); break; // RAR

					case 0xA7: ana(a); break; // ANA A
					case 0xA0: ana(b); break; // ANA B
					case 0xA1: ana(c); break; // ANA C
					case 0xA2: ana(d); break; // ANA D
					case 0xA3: ana(e); break; // ANA E
					case 0xA4: ana(h); break; // ANA H
					case 0xA5: ana(l); break; // ANA L
					case 0xA6: ana(read_byte(i8080_get_hl())); break; // ANA M
					case 0xE6: ana(read_byte_move_pc()); break; // ANI byte

					case 0xAF: xra(a); break; // XRA A
					case 0xA8: xra(b); break; // XRA B
					case 0xA9: xra(c); break; // XRA C
					case 0xAA: xra(d); break; // XRA D
					case 0xAB: xra(e); break; // XRA E
					case 0xAC: xra(h); break; // XRA H
					case 0xAD: xra(l); break; // XRA L
					case 0xAE: xra(read_byte(i8080_get_hl())); break; // XRA M
					case 0xEE: xra(read_byte_move_pc()); break; // XRI byte

					case 0xB7: ora(a); break; // ORA A
					case 0xB0: ora(b); break; // ORA B
					case 0xB1: ora(c); break; // ORA C
					case 0xB2: ora(d); break; // ORA D
					case 0xB3: ora(e); break; // ORA E
					case 0xB4: ora(h); break; // ORA H
					case 0xB5: ora(l); break; // ORA L
					case 0xB6: ora(read_byte(i8080_get_hl())); break; // ORA M
					case 0xF6: ora(read_byte_move_pc()); break; // ORI byte

					case 0xBF: cmp(a); break; // CMP A
					case 0xB8: cmp(b); break; // CMP B
					case 0xB9: cmp(c); break; // CMP C
					case 0xBA: cmp(d); break; // CMP D
					case 0xBB: cmp(e); break; // CMP E
					case 0xBC: cmp(h); break; // CMP H
					case 0xBD: cmp(l); break; // CMP L
					case 0xBE: cmp(read_byte(i8080_get_hl())); break; // CMP M
					case 0xFE: cmp(read_byte_move_pc()); break; // CPI byte

					case 0xC3: pc = read_word_move_pc(); break; // JMP
					case 0xC2: jmp_cond(flag_z == false); break; // JNZ
					case 0xCA: jmp_cond(flag_z == true); break; // JZ
					case 0xD2: jmp_cond(flag_c == false); break; // JNC
					case 0xDA: jmp_cond(flag_c == true); break; // JC
					case 0xE2: jmp_cond(flag_p == false); break; // JPO
					case 0xEA: jmp_cond(flag_p == true); break; // JPE
					case 0xF2: jmp_cond(flag_s == false); break; // JP
					case 0xFA: jmp_cond(flag_s == true); break; // JM

					case 0xE9: pc = i8080_get_hl(); break; // PCHL
					case 0xCD: call(read_word_move_pc()); break; // CALL

					case 0xC4: call_cond(flag_z == false); break; // CNZ
					case 0xCC: call_cond(flag_z == true); break; // CZ
					case 0xD4: call_cond(flag_c == false); break; // CNC
					case 0xDC: call_cond(flag_c == true); break; // CC
					case 0xE4: call_cond(flag_p == false); break; // CPO
					case 0xEC: call_cond(flag_p == true); break; // CPE
					case 0xF4: call_cond(flag_s == false); break; // CP
					case 0xFC: call_cond(flag_s == true); break; // CM

					case 0xC9: ret(); break; // RET
					case 0xC0: ret_cond(flag_z == false); break; // RNZ
					case 0xC8: ret_cond(flag_z == true); break; // RZ
					case 0xD0: ret_cond(flag_c == false); break; // RNC
					case 0xD8: ret_cond(flag_c == true); break; // RC
					case 0xE0: ret_cond(flag_p == false); break; // RPO
					case 0xE8: ret_cond(flag_p == true); break; // RPE
					case 0xF0: ret_cond(flag_s == false); break; // RP
					case 0xF8: ret_cond(flag_s == true); break; // RM

					case 0xC7: call(0x00); break; // RST 0
					case 0xCF: call(0x08); break; // RST 1
					case 0xD7: call(0x10); break; // RST 2
					case 0xDF: call(0x18); break; // RST 3
					case 0xE7: call(0x20); break; // RST 4
					case 0xEF: call(0x28); break; // RST 5
					case 0xF7: call(0x30); break; // RST 6
					case 0xFF: call(0x38); break; // RST 7

					case 0xC5: i8080_push_stack(i8080_get_bc()); break; // PUSH B
					case 0xD5: i8080_push_stack(i8080_get_de()); break; // PUSH D
					case 0xE5: i8080_push_stack(i8080_get_hl()); break; // PUSH H
					case 0xF5: i8080_push_stack(i8080_get_af()); break; // PUSH PSW
					case 0xC1: i8080_set_bc(i8080_pop_stack()); break; // POP B
					case 0xD1: i8080_set_de(i8080_pop_stack()); break; // POP D
					case 0xE1: i8080_set_hl(i8080_pop_stack()); break; // POP H
					case 0xF1: i8080_set_psw(i8080_pop_stack()); break; // POP PSW

					case 0xDB: a = input(read_byte_move_pc()); break; // IN
					case 0xD3: output(read_byte_move_pc(), a); break; // OUT

					case 0x08:
					case 0x10:
					case 0x18:
					case 0x20:
					case 0x28:
					case 0x30:
					case 0x38: break; // undocumented NOPs

					case 0xD9: ret(); break; // undocumented RET

					case 0xDD:
					case 0xED:
					case 0xFD: call(read_word_move_pc()); break; // undocumented CALLs

					case 0xCB: pc = read_word_move_pc(); break; // undocumented JMP
			}
		}
	}
}