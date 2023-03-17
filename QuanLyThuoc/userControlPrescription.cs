using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyThuoc.CreateOrReset;

namespace QuanLyThuoc
{
    public partial class userControlPrescription : UserControl,ICreate,IReset
    {
        #region Fields
        private int Index = -1;
        private int Count = 1;
        private int totalPrice = 0;
        private List<SoldDrug> soldDrug = new List<SoldDrug>(); // tạo ra một list phụ để thao tác
        private static userControlPrescription _instance;
        #endregion
        public userControlPrescription()
        {
            InitializeComponent();
        }
        #region Methods
        public void CreateColumnForDataGridView() // tạo cột
        {
            var colDrugName = new DataGridViewTextBoxColumn();
            var colDrugUnit = new DataGridViewTextBoxColumn();
            var colQuantity = new DataGridViewTextBoxColumn();
            var colDirection = new DataGridViewTextBoxColumn();
            var colDrugCost = new DataGridViewTextBoxColumn();
            var colPrice = new DataGridViewTextBoxColumn();
            var colPrescriptionID = new DataGridViewTextBoxColumn();

            colDrugName.HeaderText = "Tên thuốc";
            colDrugUnit.HeaderText = "ĐVT";
            colQuantity.HeaderText = "Số lượng";
            colDirection.HeaderText = "Hướng dẫn";
            colDrugCost.HeaderText = "Giá";
            colPrice.HeaderText = "Thành tiền";
           

            colDrugName.DataPropertyName = "DrugName";
            colDrugUnit.DataPropertyName = "DrugUnit";
            colQuantity.DataPropertyName = "Quantity";
            colDirection.DataPropertyName = "Direction";
            colDrugCost.DataPropertyName = "DrugCost";
            colPrice.DataPropertyName = "Price";
            dgvListSoldDrug.Columns.AddRange(new DataGridViewColumn[] { colDrugName, colDrugUnit, colQuantity, colDirection, colDrugCost, colPrice });
        }
        public void Reset()
        {
            Count++;
            txbPrescriptionID.Text = Convert.ToString(Count);
            txbDiagnostic.Text = null;
            txbPatientAddress.Text = null;
            txbPatientName.Text = null;
            txbPatientPhoneNumber.Text = null;
            dtPatientDateBirth.Text = null;
            dtPrescriptionDate.Text = null;
            txbTotalPrice.Text = null;
            cbDrugName.Text = null;
            txbDrugUnit.Text = null;
            txbQuantity.Text = null;
            txbDirection.Text = null;
            dgvListSoldDrug.Rows.Clear();
            totalPrice = 0;
            soldDrug = new List<SoldDrug>();
        }
        private static bool checkPhoneNumber(string iPhoneNumber)
        {
            string strRegex = @"^\d{10}";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(iPhoneNumber))
                return (true);
            else
                return (false);
        }
        #endregion
        #region Events

        private void userControlPrescription_Load(object sender, EventArgs e)
        {
            CreateColumnForDataGridView();
            foreach (var item in ListDrug.Instance.ListDrugs)
            {
                cbDrugName.Items.Add(item.DrugName);
            }
            txbPrescriptionID.Text = Convert.ToString(Count);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int price = 0;

            foreach (var item in ListDrug.Instance.ListDrugs)
            {
                if (cbDrugName.Text == item.DrugName)
                {
                    int quantityAvailable = int.Parse(item.Quantity);
                    int drugCost = int.Parse(item.DrugCost);
                    int quantity = int.Parse(txbQuantity.Text);
                    if (quantity <= quantityAvailable)
                    {
                        price = drugCost * quantity;
                        string Price = Convert.ToString(price);
                        dgvListSoldDrug.Rows.Add(item.DrugName, item.DrugUnit, txbQuantity.Text, txbDirection.Text,item.DrugCost, Price);
                        soldDrug.Add(new SoldDrug(cbDrugName.Text, txbDrugUnit.Text, txbQuantity.Text
                            , txbDirection.Text, item.DrugCost,Price, txbPrescriptionID.Text));

                        totalPrice += price;
                        string TotalPrice = Convert.ToString(totalPrice);
                        txbTotalPrice.Text = TotalPrice;
                        break;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Không đủ số lượng thuốc", "Thông báo");

                    }

                }

            }
            cbDrugName.Text = null;
            txbDrugUnit.Text = null;
            txbQuantity.Text = null;
            txbDirection.Text = null;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            totalPrice -= int.Parse(soldDrug[Index].DrugCost) * int.Parse(soldDrug[Index].Quantity);
            txbTotalPrice.Text = Convert.ToString(totalPrice);
            soldDrug.RemoveAt(Index);
            dgvListSoldDrug.Rows.Clear();
            foreach (var item in soldDrug)
            {
                dgvListSoldDrug.Rows.Add(item.DrugName, item.DrugUnit, item.Quantity, item.Direction, item.DrugCost, item.Price);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!checkPhoneNumber(txbPatientPhoneNumber.Text))
                {
                    errorProvider.SetError(txbPatientPhoneNumber, "Nhập đúng định dạng số điện thoại với 10 chữ số");
                }
                else
                {
                    foreach (var item in soldDrug)
                    {
                        ListSoldDrug.Instance.ListSold.Add(item);
                        foreach (var item2 in ListDrug.Instance.ListDrugs)
                        {
                            if (item.DrugName == item2.DrugName)
                            {
                                int quantity = int.Parse(item.Quantity);
                                int quantityAvailable = int.Parse(item2.Quantity);
                                quantityAvailable = quantityAvailable - quantity;
                                item2.Quantity = Convert.ToString(quantityAvailable);
                            }
                        }
                    }
                    ListPatient.Instance.ListInfoPatient.Add(new Patient(txbPrescriptionID.Text
                        , dtPrescriptionDate.Text, txbPatientName.Text, txbPatientPhoneNumber.Text
                        , dtPatientDateBirth.Text, txbPatientAddress.Text, txbDiagnostic.Text));
                    errorProvider.SetError(txbPatientPhoneNumber, null);
                    MessageBox.Show("Lưu hóa đơn thành công.", "Thông báo");
                    Reset();
                }

            }
        } 


        private void dgvListSoldDrug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Reset();
                Count--;
                txbPrescriptionID.Text = Convert.ToString(Count);
            }
        }

        private void cbDrugName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in ListDrug.Instance.ListDrugs)
            {
                cbDrugName.Items.Add(item.DrugName);
            }
            foreach (var item in ListDrug.Instance.ListDrugs)
            {
                if(item.DrugName == cbDrugName.Text)
                {
                    txbDrugUnit.Text = item.DrugUnit;
                    break;
                }
            }
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập chữ số!", "Thông báo");
            }
        }

        private void cbDrugName_MouseClick(object sender, MouseEventArgs e)
        {
            cbDrugName.Items.Clear();
            foreach (var item in ListDrug.Instance.ListDrugs)
            {
                cbDrugName.Items.Add(item.DrugName);
            }
        }
        #endregion
    }
}
