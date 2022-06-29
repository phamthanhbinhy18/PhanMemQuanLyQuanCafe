using System;
using System.Windows.Forms;
using DTO;
namespace MS.Main
{
    static class Program
    {
        public static DTO.AccountDTO sAccount = new AccountDTO();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_DangNhap());
        }
    }
}
