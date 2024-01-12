using System;
using System.Windows.Forms;

namespace devector
{
	public partial class form_main : Form
	{
		private Hardware hardware;
		private RecentFileManager recentFileManager = new RecentFileManager();
		FormDebugger form_debugger;
		FormMemoryMap form_memory_map;

        public form_main(Hardware _hardware)
		{
			InitializeComponent();
			hardware = _hardware;
			recentFileManager.LoadRecentFiles();
			UpdateRecentFilesMenu();

			picture_display.Image = Hardware.display.frame;
		}
		private void UpdateRecentFilesMenu()
		{
			recentFilesToolStripMenuItem.DropDownItems.Clear();
			foreach (var file in recentFileManager.Files)
			{
				var menuItem = new ToolStripMenuItem(file);
				menuItem.Click += RecentFileMenuItem_Click;
				recentFilesToolStripMenuItem.DropDownItems.Add(menuItem);
			}
		}
		private void RecentFileMenuItem_Click(object sender, EventArgs e)
		{
			var menuItem = sender as ToolStripMenuItem;
			OpenFile(menuItem.Text);
		}
		private void OpenFile(string path)
		{
			// Add your code to open the file
			recentFileManager.AddFile(path);
			UpdateRecentFilesMenu();

			hardware.load_rom(path);
            
			picture_display.Invalidate();
        }

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TODO: add realization
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Binary Files (*.bin;*.rom)|*.bin;*.rom"; // Set filter for .bin and .rom files
			openFileDialog.Title = "Select a Binary File";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				OpenFile(openFileDialog.FileName);
			}
        }

		private void memoryMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (form_debugger == null || form_debugger.IsDisposed)
            {
                FormMemoryMap form_memory_map = new FormMemoryMap();
                form_memory_map.Show();
            }
            else
            {
                form_memory_map.Focus();
            }
        }

		private void debuggerToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (form_debugger == null || form_debugger.IsDisposed)
			{
                form_debugger = new FormDebugger(picture_display);
                form_debugger.Show();
            }
			else 
			{
                form_debugger.Focus();
            }
		}
	}
}
