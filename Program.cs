using System;
using System.Windows.Forms;

namespace devector
{
    internal static class Program
    {
        static readonly Hardware hardware = new Hardware();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_main(hardware));
        }
    }
}
