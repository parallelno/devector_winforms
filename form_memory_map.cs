using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace devector
{
    public partial class form_memory_map : Form
    {
        private const int BITS_IN_BYTE = 8;

        private const int BLOCKS_W = 2;
        private const int BLOCKS_H = 4 * 5;
        private const int BLOCK_PXL_SIZE = 256;
        private const int BLOCK_BYTES_W = BLOCK_PXL_SIZE / BITS_IN_BYTE;
        private const int BLOCK_BYTES_H = BLOCK_PXL_SIZE;
        private const int BLOCK_LEN = BLOCK_BYTES_W * BLOCK_BYTES_H;

        private const int MAP_W = BLOCK_PXL_SIZE * BLOCKS_W;
        private const int MAP_H = BLOCK_PXL_SIZE * BLOCKS_H;
        private UInt32 fill_color;

        public Bitmap map;
        public static UInt32[] map_data = new UInt32[MAP_W * MAP_H];
        protected GCHandle data_handle { get; private set; }

        public form_memory_map()
        {
            InitializeComponent();
            init();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            draw_map();
        }

        void init()
        {
            data_handle = GCHandle.Alloc(map_data, GCHandleType.Pinned);
            map = new Bitmap(MAP_W, MAP_H, MAP_W * 4, PixelFormat.Format32bppArgb, data_handle.AddrOfPinnedObject());
            picturebox_map.Image = map;

            draw_map();
        }

        private void draw_map()
        {
            UInt32 color_bit_on = (UInt32)(Color.Bisque.ToArgb());
            UInt32 color_bit_off0 = (UInt32)(Color.Black.ToArgb());
            UInt32 color_bit_off1 = (UInt32)(Color.FromArgb(20, 20, 30).ToArgb());

            int blockWidth = BLOCK_PXL_SIZE;
            int blockHeight = BLOCK_PXL_SIZE;

            for (int block_vert_idx = 0; block_vert_idx < BLOCKS_H; block_vert_idx++)
            {
                for (int block_horiz_idx = 0; block_horiz_idx < BLOCKS_W; block_horiz_idx++)
                {
                    int blockX = block_horiz_idx * blockWidth;
                    int blockY = block_vert_idx * blockHeight;

                    var color_bit_off = ((block_horiz_idx % 2) + (block_vert_idx % 2)) % 2 == 0 ? color_bit_off0 : color_bit_off1;

                    draw_memory_block(block_vert_idx * BLOCKS_W + block_horiz_idx, blockX, blockY, color_bit_on, color_bit_off);
                }
            }
        }
        private void draw_memory_block(int blockIndex, int x, int y, UInt32 color_bit_on, UInt32 color_bit_off)
        {
            for (int byte_vert_idx = 0; byte_vert_idx < BLOCK_BYTES_H; byte_vert_idx++)
            {
                for (int byte_horix_idx = 0; byte_horix_idx < BLOCK_BYTES_W; byte_horix_idx++)
                {
                    uint addr = (uint)(blockIndex * BLOCK_LEN + byte_horix_idx * BLOCK_PXL_SIZE + byte_vert_idx);
                    byte memoryByte = Hardware.memory.get_byte(addr, Memory.AddrSpace.GLOBAL);

                    draw_byte(memoryByte, x + byte_horix_idx * BITS_IN_BYTE, y + BLOCK_PXL_SIZE - 1 - byte_vert_idx, color_bit_on, color_bit_off);
                }
            }
        }

        private void draw_byte(byte memoryByte, int x, int y, UInt32 color_bit_on, UInt32 color_bit_off)
        {
            for (int bit = 0; bit < BITS_IN_BYTE; bit++)
            {
                bool isSet = (memoryByte & (1 << bit)) != 0;
                fill_color = isSet ? color_bit_on : color_bit_off;
                map_data[(x + BITS_IN_BYTE - 1 - bit) + y * MAP_W] = fill_color;
            }
        }

        private void MemoryMap_Load(object sender, EventArgs e)
        {

        }
    }
}
