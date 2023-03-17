using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc {
    public partial class frmLogIn: Form {
        public frmLogIn() {
            InitializeComponent();
        }

        private void NoInput() {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!");
        }
        private void LogInControl() {
            bool check = true;
            for (int i = 0; i < ListUser.Instance.ListUserName.Count; i++) {
                if (txbUserName.Text == ListUser.Instance.ListUserName[i].UserName && txbPassword.Text == ListUser.Instance.ListUserName[i].PassWord) {
                    check = true;
                    ucAccountInformation.Account = i;
                    frmMain f = new frmMain();
                    f.Show();
                    this.Hide();
                    break;
                }
                else {
                    check = false;
                }
            }
            if (check == false) {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }

        }

        private void chkDisplayPassword_CheckedChanged(object sender, EventArgs e) {
            if (txbPassword.UseSystemPasswordChar == true) {
                txbPassword.UseSystemPasswordChar = false;
            }
            else {
                txbPassword.UseSystemPasswordChar = true;
            }
        }
        private void frmLogIn_Load(object sender, EventArgs e) {

        }

        private void btnLogIn_Click(object sender, EventArgs e) {
            if (txbUserName.Text == "" && txbPassword.Text == "") {
                NoInput();
            }
            else {
                LogInControl();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void chkDisplayPassword_CheckedChanged_1(object sender, EventArgs e) {
            txbPassword.UseSystemPasswordChar = false;
        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
