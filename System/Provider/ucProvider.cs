using System;
using System.Windows.Forms;

namespace QuanLyThuoc {
    public partial class ucProvider : UserControl {
        #region Fields
        private int Index = -1;
        #endregion
        public ucProvider() {
            InitializeComponent();
        }
        #region Events
        private void userControlProvider_Load(object sender, EventArgs e) {
            foreach (var item in Provider.Instance.ListProvider) {
                dgvListProvider.Rows.Add(item);
            }
        }

        private void txbFind_TextChanged(object sender, EventArgs e) {
            dgvListProvider.Rows.Clear();
            foreach (var item in Provider.Instance.ListProvider) {
                if (item.ToString() == txbFind.Text) {
                    dgvListProvider.Rows.Add(item.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Provider.Instance.ListProvider.Add(txbAdd.Text);
            dgvListProvider.Rows.Add(txbAdd.Text);
            txbAdd.Text = null;
        }

        private void btnAll_Click(object sender, EventArgs e) {
            dgvListProvider.Rows.Clear();
            foreach (var item in Provider.Instance.ListProvider) {
                dgvListProvider.Rows.Add(item.ToString());
            }
        }

        private void dgvListProvider_CellClick(object sender, DataGridViewCellEventArgs e) {
            Index = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Provider.Instance.ListProvider.RemoveAt(Index);
            dgvListProvider.Rows.Clear();
            foreach (var item in Provider.Instance.ListProvider) {
                dgvListProvider.Rows.Add(item.ToString());
            }
        }
        #endregion
    }
}
