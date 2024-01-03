using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devector
{
	public class Display
	{
		private Memory memory;
		
		static readonly bool MODE_256 = false;
		static readonly bool MODE_512 = true;
		private bool mode;
		private bool interruption_req;

        // a frame structure:
        // 312 scanlines:
        //		vsync: 22 lines
        //		vblank (top): 18 lines
        //		vertical resolution: 256 lines
        //      vblank (bottom): 16 lines

        // 384 pxls (192 cpu cycles / 768 clock cycles of 12 Mhz) per scanline
        //		hblank (left): 64 pxls
        //		horizontal resolution : 256 pxls
        //		hblank (right): 64 pxls

        struct Pixel
		{
			byte r, g, b, a;
		}
        static int FRAME_W	= 384;
        static int FRAME_H = 312;

        private Pixel[] frame = new Pixel[FRAME_W * FRAME_H];

		int raster_line;		// currently rasterized scanline idx
		int raster_pixel;		// currently rasterized scanline pixel
        private bool vborder;   // currently rasterized 

        public Display(Memory _memory)
		{
			memory = _memory;
			mode = MODE_256;
			interruption_req = false;
		}

		internal void reset()
		{
			raster_line = 0;
            vborder = true;
        }
	}
}
