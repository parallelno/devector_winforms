using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace devector
{
	public class Debugger
	{
		static readonly string[] mnemonics = new string[0x100]
		{ 
			"NOP", "LXI B,", "STAX B", "INX B",
			"INR B", "DCR B", "MVI B,", "RLC", "DB 0x08", "DAD B", "LDAX B", "DCX B",
			"INR C", "DCR C", "MVI C,", "RRC", "DB 0x10", "LXI D,", "STAX D", "INX D",
			"INR D", "DCR D", "MVI D,", "RAL", "DB 0x18", "DAD D", "LDAX D", "DCX D",
			"INR E", "DCR E", "MVI E,", "RAR", "DB 0x20", "LXI H,", "SHLD", "INX H",
			"INR H", "DCR H", "MVI H,", "DAA", "DB 0x28", "DAD H", "LHLD", "DCX H",
			"INR L", "DCR L", "MVI L,", "CMA", "DB 0x30", "LXI SP,", "STA", "INX SP",
			"INR M", "DCR M", "MVI M,", "STC", "DB 0x38", "DAD SP", "LDA", "DCX SP",
			"INR A", "DCR A", "MVI A,", "CMC",

			"MOV B, B", "MOV B, C", "MOV B, D", "MOV B, E", "MOV B, H", "MOV B, L",
			"MOV B, M", "MOV B, A", "MOV C, B", "MOV C, C", "MOV C, D", "MOV C, E",
			"MOV C, H", "MOV C, L", "MOV C, M", "MOV C, A", "MOV D, B", "MOV D, C",
			"MOV D, D", "MOV D, E", "MOV D, H", "MOV D, L", "MOV D, M", "MOV D, A",
			"MOV E, B", "MOV E, C", "MOV E, D", "MOV E, E", "MOV E, H", "MOV E, L",
			"MOV E, M", "MOV E, A", "MOV H, B", "MOV H, C", "MOV H, D", "MOV H, E",
			"MOV H, H", "MOV H, L", "MOV H, M", "MOV H, A", "MOV L, B", "MOV L, C",
			"MOV L, D", "MOV L, E", "MOV L, H", "MOV L, L", "MOV L, M", "MOV L, A",
			"MOV M, B", "MOV M, C", "MOV M, D", "MOV M, E", "MOV M, H", "MOV M, L",
			"HLT", "MOV M, A", "MOV A, B", "MOV A, C", "MOV A, D", "MOV A, E",
			"MOV A, H", "MOV A, L", "MOV A, M", "MOV A, A",

			"ADD B", "ADD C", "ADD D", "ADD E", "ADD H", "ADD L", "ADD M", "ADD A",
			"ADC B", "ADC C", "ADC D", "ADC E", "ADC H", "ADC L", "ADC M", "ADC A",
			"SUB B", "SUB C", "SUB D", "SUB E", "SUB H", "SUB L", "SUB M", "SUB A",
			"SBB B", "SBB C", "SBB D", "SBB E", "SBB H", "SBB L", "SBB M", "SBB A",
			"ANA B", "ANA C", "ANA D", "ANA E", "ANA H", "ANA L", "ANA M", "ANA A",
			"XRA B", "XRA C", "XRA D", "XRA E", "XRA H", "XRA L", "XRA M", "XRA A",
			"ORA B", "ORA C", "ORA D", "ORA E", "ORA H", "ORA L", "ORA M", "ORA A",
			"CMP B", "CMP C", "CMP D", "CMP E", "CMP H", "CMP L", "CMP M", "CMP A",

			"RNZ", "POP B", "JNZ", "JMP", "CNZ", "PUSH B", "ADI", "RST 0", "RZ", "RET",
			"JZ", "DB 0xCB", "CZ", "CALL", "ACI", "RST 1", "RNC", "POP D", "JNC", "OUT",
			"CNC", "PUSH D", "SUI", "RST 2", "RC", "DB 0xD9", "JC", "IN", "CC", "DB 0xDD",
			"SBI", "RST 3", "RPO", "POP H", "JPO", "XTHL", "CPO", "PUSH H", "ANI",
			"RST 4", "RPE", "PCHL", "JPE", "XCHG", "CPE", "DB 0xED", "XRI", "RST 5", "RP",
			"POP PSW", "JP", "DI", "CP", "PUSH PSW", "ORI", "RST 6", "RM", "SPHL", "JM",
			"EI", "CM", "DB 0xFD", "CPI", "RST 7" };

		Dictionary<int, string[]> labels = new Dictionary<int, string[]>();
		Dictionary<string, int> label_addrs;
		private Memory memory;
		private Hardware hardware;

		public UInt64 cc_last;

		static UInt64[] mem_runs = new UInt64[Memory.GLOBAL_MEMORY_LEN];
		static UInt64[] mem_reads = new UInt64[Memory.GLOBAL_MEMORY_LEN];
		static UInt64[] mem_writes = new UInt64[Memory.GLOBAL_MEMORY_LEN];

		public Debugger(Memory _memory)
		{
			memory = _memory;
			cc_last = 0;
		}

		// define the maximum number of bytes in a command
		const int CMD_BYTES_MAX = 3;

		// array containing lengths of commands, indexed by opcode
		static readonly byte[] cmd_lens = new byte[0x100] { 1, 3, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1,
			1, 2, 1, 1, 3, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 1,
			2, 1, 1, 1, 3, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 1, 2, 1, 1, 1, 3, 1, 1, 1, 2,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 3, 3, 3, 1, 2, 1, 1, 1, 3, 1, 3, 3, 2, 1, 1, 1, 3, 2, 3,
			1, 2, 1, 1, 1, 3, 2, 3, 1, 2, 1, 1, 1, 3, 1, 3, 1, 2, 1, 1, 1, 3, 1, 3, 1,
			2, 1, 1, 1, 3, 1, 3, 1, 2, 1, 1, 1, 3, 1, 3, 1, 2, 1 };

		// gets the length of a command based on its opcode
		UInt16 get_cmd_len(byte addr)
		{
			return cmd_lens[addr];
		}

		// array to store command parts
		static int[] cmd = new int[3];
		const int CMD_OPCODE = 0;
		const int CMD_OP_L = 1;
		const int CMD_OP_H = 2;

		// define the maximum length of data characters
		const int MAX_DATA_CHR_LEN = 11;
		const int CMD_LEN_MIN = 13;

		// gets the mnemonic for a command
		string get_mnemonic(byte _opcode, byte _data_l, byte _data_h, int _cmd_len_min)
		{
			string output = mnemonics[_opcode];

			if (cmd_lens[_opcode] == 2)
			{
				output += $" {_data_l:X2}";
			}
			else if (cmd_lens[_opcode] == 3)
			{
				int data_w = (_data_h << 8) + _data_l;
				output += $" {data_w:X4}";
			}
			/*
			// Pad the output to a minimum length
			for (int i = output.Length; i < _cmd_len_min; i++)
			{
				output += " ";
			}
			*/
			return output;
		}

		// Array defining types of opcodes
		readonly byte[] opcode_types = new byte[0x100] {
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 5, 4,
			1, 7, 7, 2, 6, 6, 5, 7, 1, 0, 7, 2, 6, 7, 5, 7, 1, 7, 7, 2, 6, 7, 5, 7, 1, 7, 7, 2, 6, 7, 5, 7, 1,
			7, 7, 2, 6, 3, 5, 7, 1, 7, 7, 2, 6, 7, 5, 7, 1, 7, 7, 2, 6, 7, 5, 7, 1, 7, 7, 2};

		// Method to get the type of an opcode
		byte get_opcode_type(byte opcode)
		{
			return opcode_types[opcode];
		}

		const byte OPCODE_PCHL = 0xE9;

		// gets disassembled line for a DB (Define Byte) command
		string get_disasm_db_line(int _addr, byte _data)
		{
			return $"0x{_addr:X4}: {_data:X2}".PadRight(MAX_DATA_CHR_LEN) + $"DB {_data:X2}";
		}

		// gets disassembled line for a command
		string get_disasm_line(int _addr, byte _opcode, byte _data_l, byte _data_h)
		{
			cmd[CMD_OPCODE] = _opcode;
			cmd[CMD_OP_L] = _data_l;
			cmd[CMD_OP_H] = _data_h;

			int cmd_len = get_cmd_len(_opcode);

			string output = $"0x{_addr:X4}";
			/*
			// print data in a format " %02X %02X %02X"
			int i = 0;
			for (; i < cmd_len; i++)
			{
				output += $" {cmd[i]:X2}";
			}
			*/
			/*
			// add whitespaces at the end of data
			i *= 3; // every byte takes three chars " %02X"
			for (; i < MAX_DATA_CHR_LEN; i++)
			{
				output += " ";
			}
			*/
			output += "\t" + get_mnemonic(_opcode, _data_l, _data_h, CMD_LEN_MIN);

			return output;
		}

		// calculates the start address for a range of lines before a given address
		UInt16 get_addr(UInt16 _end_addr, int _before_addr_lines)
		{
			if (_before_addr_lines == 0) return _end_addr;

			UInt16 start_addr = (UInt16)((_end_addr - _before_addr_lines * CMD_BYTES_MAX) & 0xffff);
			UInt16 addr = start_addr;
			int addr_diff_max = _before_addr_lines * CMD_BYTES_MAX + 1;
			const int MAX_ATTEMPTS = 41;
			uint lines = 0;

			for (int attempt = MAX_ATTEMPTS; attempt > 0 && lines != _before_addr_lines; attempt--)
			{
				addr = (UInt16)(start_addr & 0xffff);
				int addr_diff = addr_diff_max;
				lines = 0;

				while (addr_diff > 0 && addr != _end_addr)
				{
					var opcode = memory.get_byte(addr);
					var cmd_len = get_cmd_len(opcode);
					addr = (UInt16)((addr + cmd_len) & 0xffff);
					addr_diff -= cmd_len;
					lines++;
				}
				if (addr == _end_addr && lines == _before_addr_lines)
				{
					return start_addr;
				}

				start_addr++;
				addr_diff_max--;
			}

			return _end_addr;
		}

		public List<string> get_disasm(UInt16 _addr, int _lines, UInt16 _before_addr_lines)
		{
			List<string> output = new List<string>();
			if (_lines == 0)
				return output;

			int remaining_lines = _lines;
			UInt16 addr = _addr;

			if (_before_addr_lines > 0)
			{
				// calculate a new address that precedes the specified 'addr' by the before_addr_lines number of command lines.
				addr = get_addr(_addr, _before_addr_lines);

				// If it fails to find an new addr, we assume a data blob is ahead
				if (addr == _addr)
				{
					addr -= _before_addr_lines;

					remaining_lines = _lines - _before_addr_lines;

					for (int i = 0; i < _before_addr_lines; i++)
					{
						//string line_s = addr == cpu.pc ? ">" : " ";
						byte db = memory.get_byte(addr);
						string line_s = get_disasm_db_line(addr, db);

						int global_addr = memory.get_global_addr(addr, Memory.Access.RAM);
						var runs = mem_runs[global_addr];
						var reads = mem_reads[global_addr];
						var writes = mem_writes[global_addr];
						line_s += $" ({runs},{reads},{writes})";

						if (labels.ContainsKey(addr))
						{
							line_s += " " + labels[addr & 0xffff];
						}

						output.Add(line_s);
						addr += 1;
					}
				}
			}

			for (int i = 0; i < remaining_lines; i++)
			{
				//string line_s = addr == cpu.pc ? ">" : " ";

				byte opcode = memory.get_byte(addr);
				byte data_l = memory.get_byte(addr + 1);
				byte data_h = memory.get_byte(addr + 2);
				string line_s = get_disasm_line(addr, opcode, data_l, data_h);

				int global_addr = memory.get_global_addr(addr, Memory.Access.RAM);
				line_s += $"\t{mem_runs[global_addr]},{mem_reads[global_addr]},{mem_writes[global_addr]}";

				if (labels.ContainsKey(addr & 0xffff))
				{
					line_s += "\t" + labels[addr & 0xffff];
				}

				if (get_cmd_len(opcode) == 3 || opcode == OPCODE_PCHL)
				{
					UInt16 label_addr = 0;
					if (opcode == OPCODE_PCHL)
					{
						label_addr = Hardware.cpu.i8080_get_hl();
					}
					else
					{
						label_addr = (UInt16)(data_h << 8 | data_l);
					}

					if (labels.ContainsKey(label_addr))
					{
						line_s += "\t" + labels[label_addr];
					}
				}

				output.Add(line_s);

				addr += get_cmd_len(opcode);
			}

			return output;
		}
	}
}
