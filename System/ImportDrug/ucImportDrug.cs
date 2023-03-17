using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyThuoc.CreateOrReset;

namespace QuanLyThuoc {
    public partial class ucImportDrug : UserControl, ICreate, IReset {
        #region Fields
        private int Index = -1;
        private int Count = 1;
        public int totalPrice = 0;
        public List<ImportDrug> list = new List<ImportDrug>();
        #endregion
        public ucImportDrug() {
            InitializeComponent();
        }
        #region Methods
        public void CreateColumnForDataGridView() // tạo cột
        {
            var colDrugID = new DataGridViewTextBoxColumn();
            var colDrugName = new DataGridViewTextBoxColumn();
            var colDrugIngredient = new DataGridViewTextBoxColumn();
            var colDrugEffect = new DataGridViewTextBoxColumn();
            var colDrugUnit = new DataGridViewTextBoxColumn();
            var colQuantity = new DataGridViewTextBoxColumn();
            var colDrugCost = new DataGridViewTextBoxColumn();

            colDrugID.HeaderText = "Mã thuốc";
            colDrugName.HeaderText = "Tên thuốc";
            colDrugIngredient.HeaderText = "Thành phần thuốc";
            colDrugEffect.HeaderText = "Tác dụng thuốc";
            colDrugUnit.HeaderText = "ĐVT";
            colQuantity.HeaderText = "Số lượng nhập";
            colDrugCost.HeaderText = "Giá";

            colDrugID.DataPropertyName = "DrugID";
            colDrugName.DataPropertyName = "DrugName";
            colDrugIngredient.DataPropertyName = "DrugIngredient";
            colDrugEffect.DataPropertyName = "DrugEffect";
            colDrugUnit.DataPropertyName = "DrugUnit";
            colQuantity.DataPropertyName = "Quantity";
            colDrugCost.DataPropertyName = "DrugCost";

            dgvListImportDrug.Columns.AddRange(new DataGridViewColumn[] { colDrugID, colDrugName, colDrugIngredient, colDrugEffect
                , colDrugUnit, colQuantity, colDrugCost });
        }
        public void Reset() {
            Count++;
            txbImportID.Text = Convert.ToString(Count);
            cbProvider.Text = null;
            dtImportDate.Text = null;
            txbDrugID.Text = null;
            txbDrugName.Text = null;
            txbDrugIngredient.Text = null;
            txbDrugEffect.Text = null;
            txbDrugUnit.Text = null;
            txbQuantity.Text = null;
            txbDrugCost.Text = null;
            txbTotalPrice.Text = null;
            dgvListImportDrug.Rows.Clear();
            totalPrice = 0;
            list = new List<ImportDrug>();
        }
        #endregion
        #region Events
        private void userControlImportDrug_Load(object sender, EventArgs e) {
            CreateColumnForDataGridView();
            txbImportID.Text = Convert.ToString(Count);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            int price = 0;
            int drugCost = int.Parse(txbDrugCost.Text);
            int quantity = int.Parse(txbQuantity.Text);
            price = drugCost * quantity;
            //string Price = Convert.ToString(price);
            totalPrice += price;
            string TotalPrice = Convert.ToString(totalPrice);
            txbTotalPrice.Text = TotalPrice;
            dgvListImportDrug.Rows.Add(txbDrugID.Text, txbDrugName.Text, txbDrugIngredient.Text, txbDrugEffect.Text
                , txbDrugUnit.Text, txbQuantity.Text, txbDrugCost.Text);
            list.Add(new ImportDrug(txbImportID.Text, dtImportDate.Text, cbProvider.Text, txbDrugID.Text, txbDrugName.Text, txbDrugIngredient.Text
                , txbDrugEffect.Text, txbDrugUnit.Text, txbQuantity.Text, txbDrugCost.Text));
            txbDrugID.Text = null;
            txbDrugName.Text = null;
            txbDrugIngredient.Text = null;
            txbDrugEffect.Text = null;
            txbDrugUnit.Text = null;
            txbQuantity.Text = null;
            txbDrugCost.Text = null;
        }

        private void txbDrugID_TextChanged(object sender, EventArgs e) {
            foreach (var item in ListDrug.Instance.ListDrugs) {
                if (txbDrugID.Text == item.DrugID || txbDrugName.Text == item.DrugName) {
                    txbDrugName.Text = item.DrugName;
                    txbDrugIngredient.Text = item.DrugIngredient;
                    txbDrugEffect.Text = item.DrugEffect;
                    txbDrugUnit.Text = item.DrugUnit;
                    txbDrugCost.Text = item.DrugCost;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                foreach (var item in list) {
                    ListImportDrug.Instance.ListImport.Add(item);
                    int Count = 0;
                    foreach (var item2 in ListDrug.Instance.ListDrugs.ToList()) {
                        if (item.DrugID.Equals(item2.DrugID) == true) {
                            int quantity = int.Parse(item.Quantity);
                            int quantityAvailable = int.Parse(item2.Quantity);
                            quantityAvailable = quantity + quantityAvailable;
                            item2.Quantity = Convert.ToString(quantityAvailable);
                            Count++;
                        }
                    }
                    if (Count == 0) {
                        ListDrug.Instance.ListDrugs.Add(item);
                    }
                }
                        MessageBox.Show("Lưu hóa đơn thành công.", "Thông báo");
                Reset();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                Reset();
                Count--;
                txbImportID.Text = Convert.ToString(Count);
            }
        }

        private void dgvListImportDrug_CellClick(object sender, DataGridViewCellEventArgs e) {
            Index = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            totalPrice -= int.Parse(list[Index].DrugCost) * int.Parse(list[Index].Quantity);
            txbTotalPrice.Text = Convert.ToString(totalPrice);
            list.RemoveAt(Index);
            dgvListImportDrug.Rows.Clear();
            foreach (var item in list) {
                dgvListImportDrug.Rows.Add(item.DrugID, item.DrugName, item.DrugIngredient, item.DrugEffect
                , item.DrugUnit, item.Quantity, item.DrugCost);
            }
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập chữ số!", "Thông báo");
            }
        }

        private void txbDrugCost_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập chữ số!", "Thông báo");
            }
        }

        private void cbProvider_MouseClick(object sender, MouseEventArgs e) {
            cbProvider.Items.Clear();
            foreach (var item in Provider.Instance.ListProvider) {
                cbProvider.Items.Add(item);
            }
        }
        #endregion
    }
}
