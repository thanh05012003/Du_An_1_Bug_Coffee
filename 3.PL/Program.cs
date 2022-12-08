using System;
using System.Windows.Forms;
using _3.PL.Views;
using _3.PL.Views.BanHang;
using _3.PL.Views.SanPham;


namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSanPham());
        }
    }
}
