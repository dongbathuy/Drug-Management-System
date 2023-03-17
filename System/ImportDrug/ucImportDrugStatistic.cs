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
    public partial class ucImportDrugStatistic : UserControl, ICreate {
        private int Index = -1;
        public ucImportDrugStatistic() {
            InitializeComponent();
        }
        #region Methods
        public void CreateColumnForDataGridView() // tạo cột
        {
            var colImportID = new DataGridViewTextBoxColumn();
            var colImportDate = new DataGridViewTextBoxColumn();
            var colProvider = new DataGridViewTextBoxColumn();
            var colDrugID = new DataGridViewTextBoxColumn();
            var colDrugName = new DataGridViewTextBoxColumn();
            var colDrugIngredient = new DataGridViewTextBoxColumn();
            var colDrugEffect = new DataGridViewTextBoxColumn();
            var colDrugUnit = new DataGridViewTextBoxColumn();
            var colQuantity = new DataGridViewTextBoxColumn();
            var colDrugCost = new DataGridViewTextBoxColumn();

            colImportID.HeaderText = "Mã hóa đơn";
            colImportDate.HeaderText = "Ngày nhập";
            colProvider.HeaderText = "Nhà cung cấp";
            colDrugID.HeaderText = "Mã thuốc";
            colDrugName.HeaderText = "Tên thuốc";
            colDrugIngredient.HeaderText = "Thành phần thuốc";
            colDrugEffect.HeaderText = "Tác dụng thuốc";
            colDrugUnit.HeaderText = "ĐVT";
            colQuantity.HeaderText = "Số lượng nhập";
            colDrugCost.HeaderText = "Giá";

            colImportID.DataPropertyName = "ImportID";
            colImportDate.DataPropertyName = "ImportDate";
            colProvider.DataPropertyName = "Provider";
            colDrugID.DataPropertyName = "DrugID";
            colDrugName.DataPropertyName = "DrugName";
            colDrugIngredient.DataPropertyName = "DrugIngredient";
            colDrugEffect.DataPropertyName = "DrugEffect";
            colDrugUnit.DataPropertyName = "DrugUnit";
            colQuantity.DataPropertyName = "Quantity";
            colDrugCost.DataPropertyName = "DrugCost";

            dgvListImportDrug.Columns.AddRange(new DataGridViewColumn[] {colImportID, colImportDate, colProvider, colDrugID, colDrugName, colDrugIngredient, colDrugEffect
                , colDrugUnit, colQuantity, colDrugCost });
        }
        public void LoadListImportDrug() {
            dgvListImportDrug.DataSource = ListImportDrug.Instance.ListImport;
        }
        #endregion
        #region Events
        private void userControlImportDrugStatistic_Load(object sender, EventArgs e) {
            CreateColumnForDataGridView();
            LoadListImportDrug();
        }

        private void btnAll_Click(object sender, EventArgs e) {
            dgvListImportDrug.DataSource = null;
            CreateColumnForDataGridView();
            LoadListImportDrug();
            cbFind.Text = null;
            txbFind.Text = null;
        }

        private void txbFind_TextChanged(object sender, EventArgs e) {

            btnAll.Enabled = true;
            if (cbFind.Text == "Mã hóa đơn") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.ImportID == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Ngày nhập") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.ImportDate == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Nhà cung cấp") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.Provider == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Mã thuốc") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.DrugID == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Tên thuốc") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.DrugName == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Thành phần thuốc") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.DrugIngredient == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Tác dụng thuốc") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.DrugEffect == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "ĐVT") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.DrugUnit == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Số lượng nhập") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.Quantity == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
            }
            else if (cbFind.Text == "Giá") {
                List<ImportDrug> listImport = new List<ImportDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListImportDrug.Instance.ListImport) {
                    if (item.DrugCost == txbFind.Text) {
                        listImport.Add(item);
                    }
                }
                dgvListImportDrug.DataSource = null;
                CreateColumnForDataGridView();
                dgvListImportDrug.DataSource = listImport;
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
                    ws.Name = "Bảng thống kê thuốc đã nhập";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";
                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                        "Mã hóa đơn",
                        "Ngày nhập",
                        "Nhà cung cấp",
                        "Mã thuốc",
                        "Tên thuốc",
                        "Thành phần thuốc",
                        "Tác dụng thuốc",
                        "ĐVT",
                        "Số lượng nhập",
                        "Giá"
                            };
                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();
                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Bảng thống kê thuốc đã nhập";
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
                    List<ImportDrug> list = new List<ImportDrug>();
                    // Lặp qua tất cả các dòng trong DataGridView
                    for (int i = 0; i < dgvListImportDrug.Rows.Count; i++) {
                        int j = 0;
                        // Tạo một đối tượng DrugImport mới từ dữ liệu trong mỗi dòng
                        string ImportID = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string ImportDate = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string Provider = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string DrugID = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string DrugName = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string DrugIngredient = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string DrugEffect = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string DrugUnit = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string Quantity = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        string DrugCost = dgvListImportDrug.Rows[i].Cells[j++].Value.ToString();
                        // Thêm đối tượng Drugs mới vào List
                        list.Add(new ImportDrug(ImportID, ImportDate, Provider, DrugID, DrugName, DrugIngredient, DrugEffect
                            , DrugUnit, Quantity, DrugCost));
                    }
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in list) {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;
                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;
                        //gán giá trị cho từng cell
                        //
                        ws.Cells[rowIndex, colIndex++].Value = item.ImportID;
                        ws.Cells[rowIndex, colIndex++].Value = item.ImportDate;
                        ws.Cells[rowIndex, colIndex++].Value = item.Provider;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugID;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugName;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugIngredient;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugEffect;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugUnit;
                        ws.Cells[rowIndex, colIndex++].Value = int.Parse(item.Quantity);
                        ws.Cells[rowIndex, colIndex++].Value = int.Parse(item.DrugCost);
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
        #endregion

        private void dgvListImportDrug_CellClick(object sender, DataGridViewCellEventArgs e) {
            Index = e.RowIndex;
        }
    }
}
