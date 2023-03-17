using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QuanLyThuoc.CreateOrReset;

namespace QuanLyThuoc {
    public partial class ucDrug : UserControl, ICreate, IReset {
        #region Fields
        private int Index = -1;
        private static ucDrug inStance;
        #endregion
        #region Properties
        public static ucDrug Instance {
            get {
                if (inStance == null)
                    inStance = new ucDrug();
                return inStance;
            }
            set => inStance = value;
        }
        #endregion
        public ucDrug() {
            InitializeComponent();
        }
        #region Methods
        public void CreateColumnForDataGridView() {         // tạo cột
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
            colQuantity.HeaderText = "Số lượng hiện có";
            colDrugCost.HeaderText = "Giá";

            colDrugID.DataPropertyName = "DrugID";
            colDrugName.DataPropertyName = "DrugName";
            colDrugIngredient.DataPropertyName = "DrugIngredient";
            colDrugEffect.DataPropertyName = "DrugEffect";
            colDrugUnit.DataPropertyName = "DrugUnit";
            colQuantity.DataPropertyName = "Quantity";
            colDrugCost.DataPropertyName = "DrugCost";

            dgvListDrugs.Columns.AddRange(new DataGridViewColumn[] { colDrugID, colDrugName, colDrugIngredient, colDrugEffect
                , colDrugUnit, colQuantity, colDrugCost });
        }

        public void LoadListDrugs() {
            dgvListDrugs.DataSource = ListDrug.Instance.ListDrugs;
        }
        public void Reset() {
            txbDrugID.Text = null;
            txbDrugName.Text = null;
            txbDrugIngredient.Text = null;
            txbDrugEffect.Text = null;
            txbDrugUnit.Text = null;
            txbQuantityAvailable.Text = null;
            txbDrugCost.Text = null;
        }
        private void LoadUpdate() {         // dùng khi cập nhật hoặc sửa bảng
            dgvListDrugs.DataSource = null;
            CreateColumnForDataGridView();
            LoadListDrugs();
            Reset();
        }
        #endregion
        #region Events
        private void userControlDrug_Load(object sender, EventArgs e) {
            CreateColumnForDataGridView();
            LoadListDrugs();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            foreach (var item in ListDrug.Instance.ListDrugs) {
                if (item.DrugID == txbDrugID.Text || item.DrugName == txbDrugName.Text) {
                    MessageBox.Show("Đã tồn tại! \nVui lòng kiểm tra lại!");
                    Reset();
                }
                else {
                    ListDrug.Instance.ListDrugs.Add(new Drugs(txbDrugID.Text, txbDrugName.Text, txbDrugIngredient.Text
                        , txbDrugEffect.Text, txbDrugUnit.Text, txbQuantityAvailable.Text, txbDrugCost.Text));
                    LoadUpdate();
                }
                break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            foreach (var item in ListDrug.Instance.ListDrugs) {
                if (txbDrugID.Text == item.DrugID || txbDrugName.Text == item.DrugName) {
                    item.DrugIngredient = txbDrugIngredient.Text;
                    item.DrugEffect = txbDrugEffect.Text;
                    item.DrugUnit = txbDrugUnit.Text;
                    item.Quantity = txbQuantityAvailable.Text;
                    item.DrugCost = txbDrugCost.Text;
                    LoadUpdate();
                }
            }
        }

        private void dgvListDrugs_CellClick(object sender, DataGridViewCellEventArgs e) {
            Index = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            ListDrug.Instance.ListDrugs.RemoveAt(Index);
            dgvListDrugs.DataSource = null;
            CreateColumnForDataGridView();
            LoadListDrugs();

        }

        private void btnAll_Click(object sender, EventArgs e) {
            dgvListDrugs.DataSource = null;
            CreateColumnForDataGridView();
            LoadListDrugs();
            cbFind.Text = null;
            txbFind.Text = null;
        }

        private void txbFind_TextChanged(object sender, EventArgs e) {
            btnAll.Enabled = true;
            if (cbFind.Text == "Mã thuốc") {
                List<Drugs> listDrug = new List<Drugs>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListDrug.Instance.ListDrugs) {
                    if (item.DrugID == txbFind.Text) {
                        listDrug.Add(item);
                    }
                }
                dgvListDrugs.DataSource = null;
                CreateColumnForDataGridView();
                dgvListDrugs.DataSource = listDrug;
            }
            else if (cbFind.Text == "Tên thuốc") {
                List<Drugs> listDrug = new List<Drugs>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListDrug.Instance.ListDrugs) {
                    if (item.DrugName == txbFind.Text) {
                        listDrug.Add(item);
                    }
                }
                dgvListDrugs.DataSource = null;
                CreateColumnForDataGridView();
                dgvListDrugs.DataSource = listDrug;
            }
            else if (cbFind.Text == "Thành phần thuốc") {
                List<Drugs> listDrug = new List<Drugs>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListDrug.Instance.ListDrugs) {
                    if (item.DrugIngredient == txbFind.Text) {
                        listDrug.Add(item);
                    }
                }
                dgvListDrugs.DataSource = null;
                CreateColumnForDataGridView();
                dgvListDrugs.DataSource = listDrug;
            }
            else if (cbFind.Text == "Tác dụng của thuốc") {
                List<Drugs> listDrug = new List<Drugs>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListDrug.Instance.ListDrugs) {
                    if (item.DrugEffect == txbFind.Text) {
                        listDrug.Add(item);
                    }
                }
                dgvListDrugs.DataSource = null;
                CreateColumnForDataGridView();
                dgvListDrugs.DataSource = listDrug;
            }
            else if (cbFind.Text == "ĐVT") {
                List<Drugs> listDrug = new List<Drugs>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListDrug.Instance.ListDrugs) {
                    if (item.DrugUnit == txbFind.Text) {
                        listDrug.Add(item);
                    }
                }
                dgvListDrugs.DataSource = null;
                CreateColumnForDataGridView();
                dgvListDrugs.DataSource = listDrug;
            }
            else if (cbFind.Text == "Số lượng hiện có") {
                List<Drugs> listDrug = new List<Drugs>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListDrug.Instance.ListDrugs) {
                    if (item.Quantity == txbFind.Text) {
                        listDrug.Add(item);
                    }
                }
                dgvListDrugs.DataSource = null;
                CreateColumnForDataGridView();
                dgvListDrugs.DataSource = listDrug;
            }
            else if (cbFind.Text == "Giá thuốc") {
                List<Drugs> listDrug = new List<Drugs>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListDrug.Instance.ListDrugs) {
                    if (item.DrugCost == txbFind.Text) {
                        listDrug.Add(item);
                    }
                }
                dgvListDrugs.DataSource = null;
                CreateColumnForDataGridView();
                dgvListDrugs.DataSource = listDrug;
            }
        }

        private void txbDrugID_TextChanged(object sender, EventArgs e) {
            foreach (var item in ListDrug.Instance.ListDrugs) {
                if (txbDrugID.Text == item.DrugID) {
                    txbDrugID.Text = item.DrugID;
                    txbDrugName.Text = item.DrugName;
                    txbDrugIngredient.Text = item.DrugIngredient;
                    txbDrugEffect.Text = item.DrugEffect;
                    txbDrugUnit.Text = item.DrugUnit;
                    txbQuantityAvailable.Text = item.Quantity;
                    txbDrugCost.Text = item.DrugCost;
                }
            }
        }
        private void txbDrugName_TextChanged(object sender, EventArgs e) {
            foreach (var item in ListDrug.Instance.ListDrugs) {
                if (txbDrugName.Text == item.DrugName) {
                    txbDrugID.Text = item.DrugID;
                    txbDrugName.Text = item.DrugName;
                    txbDrugIngredient.Text = item.DrugIngredient;
                    txbDrugEffect.Text = item.DrugEffect;
                    txbDrugUnit.Text = item.DrugUnit;
                    txbQuantityAvailable.Text = item.Quantity;
                    txbDrugCost.Text = item.DrugCost;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();
            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK) {
                filePath = dialog.FileName;
            }
            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath)) {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            try {
                using (ExcelPackage p = new ExcelPackage()) {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Đồng Bá Thùy";
                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Thuốc";
                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("ĐBT sheet");
                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];
                    // đặt tên cho sheet
                    ws.Name = "Bảng thống kê thuốc";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";
                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Mã thuốc",
                                                "Tên thuốc",
                                                "Thành phần thuốc",
                                                "Tác dụng thuốc",
                                                "ĐVT",
                                                "Số lượng hiện có",
                                                "Giá"
                            };
                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();
                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Bảng thông tin thuốc";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    int colIndex = 1;
                    int rowIndex = 2;
                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader) {
                        var cell = ws.Cells[rowIndex, colIndex];
                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;
                        //gán giá trị
                        cell.Value = item;
                        colIndex++;
                    }
                    // lấy ra danh sách UserInfo từ ItemSource của DataGrid
                    List<Drugs> list = new List<Drugs>();
                    // Lặp qua tất cả các dòng trong DataGridView
                    for (int i = 0; i < dgvListDrugs.Rows.Count; i++) {
                        int j = 0;
                        // Tạo một đối tượng Drugs mới từ dữ liệu trong mỗi dòng
                        string DrugID = dgvListDrugs.Rows[i].Cells[j++].Value.ToString();
                        string DrugName = dgvListDrugs.Rows[i].Cells[j++].Value.ToString();
                        string DrugIngredient = dgvListDrugs.Rows[i].Cells[j++].Value.ToString();
                        string DrugEffect = dgvListDrugs.Rows[i].Cells[j++].Value.ToString();
                        string DrugUnit = dgvListDrugs.Rows[i].Cells[j++].Value.ToString();
                        string Quantity = dgvListDrugs.Rows[i].Cells[j++].Value.ToString();
                        string DrugCost = dgvListDrugs.Rows[i].Cells[j++].Value.ToString();
                        // Thêm đối tượng Drugs mới vào List
                        list.Add(new Drugs(DrugID, DrugName, DrugIngredient, DrugEffect, DrugUnit, Quantity, DrugCost));
                    }
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in list) {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;
                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;
                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugID;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugName;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugIngredient;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugEffect;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugUnit;
                        ws.Cells[rowIndex, colIndex++].Value = item.Quantity;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugCost;
                        /*// lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        ws.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();*/
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception Ex) {
                MessageBox.Show("Có lỗi khi lưu file!");
            }
        }

        private void txbQuantityAvailable_KeyPress(object sender, KeyPressEventArgs e) {
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
        #endregion
    }
}
