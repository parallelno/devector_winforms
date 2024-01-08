using System;
using System.Drawing;
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

        private int scale = 1;

        public form_memory_map()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            paint(sender, e);
        }

        private void paint(object sender, PaintEventArgs e)
        {
            var color_bit_on = Brushes.Bisque;
            var color_bit_off0 = Brushes.Black;
            var color_bit_off1 = new SolidBrush(Color.FromArgb(20, 20, 30));

            int blockWidth = BLOCK_PXL_SIZE;
            int blockHeight = BLOCK_PXL_SIZE;

            for (int block_vert_idx = 0; block_vert_idx < BLOCKS_H; block_vert_idx++)
            {
                for (int block_horiz_idx = 0; block_horiz_idx < BLOCKS_W; block_horiz_idx++)
                {
                    int blockX = block_horiz_idx * blockWidth;
                    int blockY = block_vert_idx * blockHeight;

                    var color_bit_off = ((block_horiz_idx % 2) + (block_vert_idx % 2)) % 2 == 0 ? color_bit_off0 : color_bit_off1;

                    DrawMemoryBlock(e.Graphics, block_vert_idx * BLOCKS_W + block_horiz_idx, blockX, blockY, color_bit_on, color_bit_off);
                }
            }
        }
        private void DrawMemoryBlock(Graphics graphics, int blockIndex, int x, int y, Brush color_bit_on, Brush color_bit_off)
        {
            for (int byte_vert_idx = 0; byte_vert_idx < BLOCK_BYTES_H; byte_vert_idx++)
            {
                for (int byte_horix_idx = 0; byte_horix_idx < BLOCK_BYTES_W; byte_horix_idx++)
                {
                    int addr = blockIndex * BLOCK_LEN + byte_horix_idx * BLOCK_PXL_SIZE + byte_vert_idx;
                    byte memoryByte = Hardware.memory.get_byte(addr, Memory.AddrSpace.GLOBAL);

                    DrawByte(graphics, memoryByte, x + byte_horix_idx * BITS_IN_BYTE, y + BLOCK_PXL_SIZE - 1 - byte_vert_idx, color_bit_on, color_bit_off);
                }
            }
        }

        private void DrawByte(Graphics graphics, byte memoryByte, int x, int y, Brush color_bit_on, Brush color_bit_off)
        {
            for (int bit = 0; bit < BITS_IN_BYTE; bit++)
            {
                bool isSet = (memoryByte & (1 << bit)) != 0;
                var color = isSet ? color_bit_on : color_bit_off;
                graphics.FillRectangle(color, (x + BITS_IN_BYTE - 1 - bit) * scale, y * scale, scale, scale);
            }
        }

        private void MemoryMap_Load(object sender, EventArgs e)
        {

        }
    }
}
