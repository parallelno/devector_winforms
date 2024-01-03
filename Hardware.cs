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
		public static Display video;
        public static Debugger debugger;

		public Hardware() {
            memory = new Memory();
			io = new IO(memory);
            cpu = new I8080(memory.get_byte, memory.set_byte, io.port_in, io.port_out);
			video = new Display(memory);

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

        // executes one instruction
        public static void step()
        {
            debugger.step();
            cpu.step();
        }

        // called by the timer 50 times per second
        // it generates the frame texture and triggers the interruption
        public void execute_frame()
        {
			video.reset();
        }
    }
}
