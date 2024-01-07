using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

		const bool MODE_256 = false;
		const bool MODE_512 = true;
		private bool mode;
		public bool T50HZ; // interruption request

		const int FRAME_W = 768;
		const int FRAME_H = 312;
		const int VSYNC = 22;
		const int VBLANK_TOP = 18;
		const int BORDER_TOP = VSYNC + VBLANK_TOP;
		const int BORDER_LEFT = 128;
		const int RES_W = 512;
		const int RES_H = 256;
		const int RASTERIZED_PXLS = 16;
		const int PALETTE_LEN = 16;


		public const int FRAME_CC = FRAME_W * FRAME_H;

		public Bitmap frame = new Bitmap(FRAME_W, FRAME_H, PixelFormat.Format32bppArgb);
		public Color[] palette = new Color[PALETTE_LEN];
		private Color fill_color = Color.Black;


		public int raster_line;      // currently rasterized scanline idx from the bottom
		public int raster_pixel;		// currently rasterized scanline pixel

		public Display(Memory _memory)
		{
			init();
		}

		public void init()
		{
			// erase the frame
			using (Graphics gfx = Graphics.FromImage(frame))
			{
				using (Brush blackBrush = new SolidBrush(Color.Black))
				{
					gfx.FillRectangle(blackBrush, 0, 0, frame.Width, frame.Height);
				}
			}
			// reset the palette
			for (int i = 0; i < PALETTE_LEN; i++)
			{
				palette[i] = Color.Yellow;
			}
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
				draw_border_8_pxls_();
			}
			else
			{
				draw_active_8_pxls();
			}
			// advance the raster_pixel & raster_line
			raster_pixel = (raster_pixel + RASTERIZED_PXLS) % FRAME_W;
			raster_line = raster_pixel == 0 ? (raster_line + 1) % FRAME_H : raster_line;

			T50HZ = (raster_pixel + raster_line) == 0;
		}

		void draw_active_8_pxls()
		{
			byte[] memory = Memory.memory;

            var pos_addr = (raster_pixel - BORDER_LEFT) / RASTERIZED_PXLS * RES_H + RES_H - 1 - (raster_line - BORDER_TOP);

            UInt16 addr8 = (UInt16)(0x8000 + pos_addr);
			UInt16 addrA = (UInt16)(0xA000 + pos_addr);
			UInt16 addrC = (UInt16)(0xC000 + pos_addr);
			UInt16 addrE = (UInt16)(0xE000 + pos_addr);

			var color_byte8 = Memory.memory[addr8];
			var color_byteA = Memory.memory[addrA];
			var color_byteC = Memory.memory[addrC];
			var color_byteE = Memory.memory[addrE];

            for (int i = 0; i < RASTERIZED_PXLS; i += 2)
            {
				int color_bit8 = (color_byte8 >> (7 - i/2)) & 1;
				int color_bitA = (color_byteA >> (7 - i/2)) & 1;
				int color_bitC = (color_byteC >> (7 - i/2)) & 1;
				int color_bitE = (color_byteE >> (7 - i/2)) & 1;

				int palette_idx = color_bit8 | color_bitA << 1 | color_bitC << 2 | color_bitE << 3;

				fill_color = color_bitE == 0 ? Color.Black : Color.White; // palette[palette_idx];

				frame.SetPixel(raster_pixel + i, raster_line, fill_color);
				frame.SetPixel(raster_pixel + i + 1, raster_line, fill_color);
			}
		}

		void draw_border_8_pxls_()
		{
			for (int i = 0; i < RASTERIZED_PXLS; i += 2)
			{
				fill_color = Color.DarkOliveGreen;
				frame.SetPixel(raster_pixel + i, raster_line, fill_color);
                frame.SetPixel(raster_pixel + i + 1, raster_line, fill_color);
            }
		}
	}
}
