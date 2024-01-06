using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace devector
{
	public class Display
	{
        // phisical frame config:
        // 312 scanlines in a frame:
        //		vsync: 22 lines
        //		vblank (top): 18 lines
        //		vertical resolution: 256 lines
        //      vblank (bottom): 16 lines

        // scanline has 768/384 pxls (MODE_512/MODE_256). A scanline rasterising time takes 192 cpu cycles (3 Mhz tick rate) or 768 quarters of a cpu cycle (12 Mhz tick rate).
        //		hblank (left): 128/64 pxls
        //		horizontal resolution : 512/256 pxls
        //		hblank (right): 128/64 pxls

        // For simplisity of the logic the diplay buffer horizontal resolution
        // is always 768 pxls to fit the 512 mode.
        // It rasters 4 horizontal pxls every cpu cycle no mater the mode.
        // In MODE_256 it dups every 2 horizontal pxls.

        private Memory memory;

        const bool MODE_256 = false;
        const bool MODE_512 = true;
		private bool mode;
		public bool INTA; // interruption request

        struct Pixel
		{
			byte r, g, b, a;
		}
        const uint FRAME_W	= 384 * 2;
        const uint FRAME_H = 312;
        const uint VSYNC = 22;
        const uint VBLANK_TOP = 18;
        const uint BORDER_TOP = VSYNC + VBLANK_TOP;
        const uint BORDER_LEFT = 128;
        const uint RES_W = 512;
        const uint RES_H = 256;
        const uint RASTERIZED_PXLS = 16;

        public const uint FRAME_CC = FRAME_W * FRAME_H;

        private Pixel[] frame = new Pixel[FRAME_W * FRAME_H];

        public uint raster_line;      // currently rasterized scanline idx from the bottom
        public uint raster_pixel;		// currently rasterized scanline pixel

        public Display(Memory _memory)
		{
			memory = _memory;
            reset();
        }

        public void reset()
        {
            mode = MODE_256;
            raster_line = 0;
            raster_pixel = 0;
            Array.Clear(frame, 0, frame.Length);
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
            // advance the raster_pixel & raster_line
            raster_pixel = (raster_pixel + RASTERIZED_PXLS) % FRAME_W;
			raster_line = raster_pixel == 0 ? (raster_line + 1) % FRAME_H : raster_line;

            INTA = (raster_pixel + raster_line) == 0;
        }
    }
}
