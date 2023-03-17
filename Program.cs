using System;
using System.Windows.Forms;

namespace QuanLyThuoc {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
/*            try {*/
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogIn());
/*            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
