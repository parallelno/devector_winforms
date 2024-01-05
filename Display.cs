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

        const bool MODE_256 = false;
        const bool MODE_512 = true;
		private bool mode;
		public bool INT; // interruption request

        // 312 scanlines in a frame:
        //		vsync: 22 lines
        //		vblank (top): 18 lines
        //		vertical resolution: 256 lines
        //      vblank (bottom): 16 lines

        // scanline has 768/384 pxls (MODE_512/MODE_256). A scanline rasterising time takes 192 cpu cycles (3 Mhz tick rate) or 768 quarters of a cpu cycle (12 Mhz tick rate).
        //		hblank (left): 128/64 pxls
        //		horizontal resolution : 512/256 pxls
        //		hblank (right): 128/64 pxls

        struct Pixel
		{
			byte r, g, b, a;
		}
        const int FRAME_W	= 384 * 2;
        const int FRAME_H = 312;
        const int VSYNC = 22;
        const int VBLANK_TOP = 18;
        const int BORDER_TOP = VSYNC + VBLANK_TOP;
        const int BORDER_LEFT = 128;
        const int RES_W = 512;
        const int RES_H = 256;

        public const int FRAME_CC = FRAME_W * FRAME_H;

        private Pixel[] frame = new Pixel[FRAME_W * FRAME_H];

		int raster_line;		// currently rasterized scanline idx from the bottom
		int raster_pixel;		// currently rasterized scanline pixel

        public Display(Memory _memory)
		{
			memory = _memory;
			mode = MODE_256;
            raster_line = 0;
            raster_pixel = 0;
        }

        // to draw a pxl
        internal void rasterize()
		{
			if (raster_line < BORDER_TOP || raster_line >= BORDER_TOP + RES_H ||
				raster_pixel < BORDER_LEFT || raster_pixel >= BORDER_LEFT + RES_W)
			{
				//draw_border();
			}
			else
			{
				//draw_pxl();
			}
            raster_pixel = raster_pixel >= FRAME_W - 1 ? 0 : raster_pixel + 1;
			raster_line = raster_pixel == 0 ? raster_line + 1 : raster_line;
			INT = (raster_line == 0) && (raster_line == 0);
        }
    }
}
