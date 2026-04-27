using System;
using System.Windows.Forms;

namespace PetStore2
{
    internal static class Program
    {
        public static int TaiKhoanID { get; set; }
        public static string Username { get; set; }
        public static string HoTen { get; set; }
        public static int RoleID { get; set; }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.frmLogin());
        }
    }
}
