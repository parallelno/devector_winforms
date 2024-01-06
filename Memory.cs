using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devector
{
	public class Memory
	{
		public static int MEMORY_MAIN_LEN = 64 * 1024;
		public static int MEMORY_RAMDISK_LEN = 256 * 1024;
		static int RAM_DISK_PAGE_LEN = 64 * 1024;
		static int RAMDISK_MAX = 1;

		public static int GLOBAL_MEMORY_LEN = MEMORY_MAIN_LEN + MEMORY_RAMDISK_LEN * RAMDISK_MAX;
		static byte[] memory = new byte[GLOBAL_MEMORY_LEN];

		static int ROM_LOAD_ADDR = 0x100;

		public enum AddrSpace
		{
			RAM, STACK, GLOBAL
		}

		public bool mapping_mode_stack;
		public int mapping_page_stack;
		public byte mapping_mode_ram;
		public int mapping_page_ram;

		public Memory()
		{
			init();
		}

		public void init()
		{
			Array.Clear(memory, 0, memory.Length);

			mapping_mode_stack = false;
			mapping_page_stack = 0;
			mapping_mode_ram = 0;
			mapping_page_ram = 0;
		}

		public byte get_byte(int addr, AddrSpace addr_space = AddrSpace.RAM)
		{
			addr = get_global_addr((UInt16)(addr & 0xffff), addr_space);
			return memory[addr];
		}

		public void set_byte(int addr, byte value, AddrSpace addr_space = AddrSpace.RAM)
		{
			addr = get_global_addr((UInt16)(addr & 0xffff), addr_space);
			memory[addr] = value;
		}

        public int get_word(int addr, AddrSpace access = AddrSpace.RAM)
        {
            var addr0 = get_global_addr((UInt16)(addr & 0xffff), access);
            var addr1 = get_global_addr((UInt16)((addr+1) & 0xffff), access);
			var lb = memory[addr0];
            var hb = memory[addr1];
			return hb << 8 | lb;
        }

        internal int length()
		{
			return memory.Length;
		}

		internal void load(byte[] file_data)
		{
			Array.Copy(file_data, 0, memory, ROM_LOAD_ADDR, file_data.Length);
		}

		// converts an UInt16 addr to a global addr depending on the ram/stack mapping modes
		public int get_global_addr(UInt16 addr, AddrSpace addr_space)
		{
			if (addr_space == AddrSpace.STACK)
			{
				if (mapping_mode_stack)
				{
					return addr + mapping_page_stack * RAM_DISK_PAGE_LEN;
				}
			}
			else if (addr_space == AddrSpace.RAM)
			{
				if (addr < 0x8000 || mapping_mode_ram == 0) return addr;

				if (((mapping_mode_ram & 0x20) > 0) && (addr >= 0xa000) && (addr <= 0xdfff))
				{
					return addr + mapping_page_ram * RAM_DISK_PAGE_LEN;
				}
				if (((mapping_mode_ram & 0x40) > 0) && (addr >= 0x8000) && (addr <= 0x9fff))
				{
					return addr + mapping_page_ram * RAM_DISK_PAGE_LEN;
				}
				if (((mapping_mode_ram & 0x80) > 0) && (addr >= 0xe000) && (addr <= 0xffff))
				{
					return addr + mapping_page_ram * RAM_DISK_PAGE_LEN;
				}
			}

			return addr;
		}
	}
}
