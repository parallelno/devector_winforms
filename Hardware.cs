using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devector
{
	public class Hardware
	{

		public static I8080 cpu;
		public static Memory memory;
		public static IO io;
		public static Display display;
		public static Debugger debugger;

		public Hardware() {
			memory = new Memory();
			io = new IO(memory);
			cpu = new I8080(memory.get_byte, memory.set_byte, io.port_in, io.port_out);
			display = new Display(memory);

			debugger = new Debugger(memory);
		}

		public void load_rom(string path)
		{
			byte[] file_data = null;

			try
			{
				file_data = File.ReadAllBytes(path);

				if (file_data != null && file_data.Length > 0 && file_data.Length <= Memory.MEMORY_MAIN_LEN)
				{
					init();
					memory.load(file_data);
					Console.WriteLine("file loaded: " + path);
				}
			}
			catch (DirectoryNotFoundException dirEx)
			{
				Console.WriteLine("Directory not found: " + dirEx.Message);
			}
		}

		private void init()
		{
			memory.init();
			cpu.init();
        }

        // rasterizes the frame. it's called by the 50 Hz times
        public static void execute_frame()
		{
			// per pixel loop
			for (int pxl_idx = 0; pxl_idx < Display.FRAME_CC; pxl_idx++)
			{
				display.rasterize();
                cpu.execute_machine_cycle(display.INT);
            }
        }

		public static void execute_instruction()
		{
            do
			{
                display.rasterize();
                cpu.execute_machine_cycle(display.INT);
            } while (cpu.machine_cycle == I8080.INSTR_EXECUTED);
        }
	}
}
