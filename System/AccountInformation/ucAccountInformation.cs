using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc {
    public partial class ucAccountInformation : UserControl {
        #region Fields
        private static int account;
        public static int Account { get => account; set => account = value; }
        #endregion
        public ucAccountInformation() {
            InitializeComponent();
        }
        #region Events
        private void userAccountInformation_Load(object sender, EventArgs e) {
            for (int item = 0; item < ListUser.Instance.ListUserName.Count; item++) {
                if (item == Account) {
                    lblUserName.Text = ListUser.Instance.ListUserName[item].UserName;
                    lblName.Text = ListUser.Instance.ListUserName[item].Name;
                    lblSex.Text = ListUser.Instance.ListUserName[item].Sex;
                    lblAge.Text = ListUser.Instance.ListUserName[item].Age;
                    lblAddress.Text = ListUser.Instance.ListUserName[item].Address;
                    lblLevel.Text = ListUser.Instance.ListUserName[item].Level;
                }
            }
        }
        #endregion
    }
}
