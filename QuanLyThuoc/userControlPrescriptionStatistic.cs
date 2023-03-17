using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using QuanLyThuoc.CreateOrReset;

namespace QuanLyThuoc
{
    public partial class userControlPrescriptionStatistic : UserControl, ICreate
    {
        public userControlPrescriptionStatistic()
        {
            InitializeComponent();
        }
        #region Methods
        public void CreateColumnForDataGridView() // tạo cột
        {
            var colDrugName = new DataGridViewTextBoxColumn();
            var colDrugUnit = new DataGridViewTextBoxColumn();
            var colQuantity = new DataGridViewTextBoxColumn();
            var colPrescriptionID = new DataGridViewTextBoxColumn();

            colDrugName.HeaderText = "Tên thuốc";
            colDrugUnit.HeaderText = "ĐVT";
            colQuantity.HeaderText = "Số lượng";
            colPrescriptionID.HeaderText = "Mã hóa đơn";

            colDrugName.DataPropertyName = "DrugName";
            colDrugUnit.DataPropertyName = "DrugUnit";
            colQuantity.DataPropertyName = "Quantity";
            colPrescriptionID.DataPropertyName = "PrescriptionID";
            dgvPrescriptionStatistic.Columns.AddRange(new DataGridViewColumn[] { colDrugName, colDrugUnit, colQuantity, colPrescriptionID });
        }
        #endregion
        #region Events
        private void userControlPrescriptionStatistic_Load(object sender, EventArgs e)
        {
            CreateColumnForDataGridView();
            foreach (var item in ListSoldDrug.Instance.ListSold)
            {
                dgvPrescriptionStatistic.Rows.Add(item.DrugName, item.DrugUnit, item.Quantity, item.PrescriptionID);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            {
                dgvPrescriptionStatistic.Rows.Clear();
                dgvPrescriptionStatistic.DataSource = null;
                foreach (var item in ListSoldDrug.Instance.ListSold)
                {
                    dgvPrescriptionStatistic.Rows.Add(item.DrugName, item.DrugUnit, item.Quantity, item.PrescriptionID);
                }
                txbFind.Text = null;
                cbFind.Text = null;
            }
        }

        private void txbFind_TextChanged(object sender, EventArgs e)
        {
            dgvPrescriptionStatistic.DataSource = null;
            dgvPrescriptionStatistic.Rows.Clear();
            if (cbFind.Text == "Tên thuốc")
            {
                List<SoldDrug> listSoldDrug = new List<SoldDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListSoldDrug.Instance.ListSold)
                {
                    if (item.DrugName == txbFind.Text)
                    {
                        listSoldDrug.Add(item);
                        dgvPrescriptionStatistic.Rows.Add(item.DrugName, item.DrugUnit, item.Quantity, item.PrescriptionID);
                    }
                }
            }
            else if (cbFind.Text == "ĐVT")
            {
                dgvPrescriptionStatistic.DataSource = null;
                dgvPrescriptionStatistic.Rows.Clear();
                List<SoldDrug> listSoldDrug = new List<SoldDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListSoldDrug.Instance.ListSold)
                {
                    if (item.DrugUnit == txbFind.Text)
                    {
                        listSoldDrug.Add(item);
                        dgvPrescriptionStatistic.Rows.Add(item.DrugName, item.DrugUnit, item.Quantity, item.PrescriptionID);
                    }
                }

            }
            else if (cbFind.Text == "Số lượng")
            {
                dgvPrescriptionStatistic.DataSource = null;
                dgvPrescriptionStatistic.Rows.Clear();
                List<SoldDrug> listSoldDrug = new List<SoldDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListSoldDrug.Instance.ListSold)
                {
                    if (item.Quantity == txbFind.Text)
                    {
                        listSoldDrug.Add(item);
                        dgvPrescriptionStatistic.Rows.Add(item.DrugName, item.DrugUnit, item.Quantity, item.PrescriptionID);
                    }
                }
            }
            else if (cbFind.Text == "Mã hóa đơn")
            {
                dgvPrescriptionStatistic.DataSource = null;
                dgvPrescriptionStatistic.Rows.Clear();
                /*                CreateColumnForDataGridView();*/
                List<SoldDrug> listSoldDrug = new List<SoldDrug>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListSoldDrug.Instance.ListSold)
                {
                    if (item.PrescriptionID == txbFind.Text)
                    {
                        listSoldDrug.Add(item);
                        dgvPrescriptionStatistic.Rows.Add(item.DrugName, item.DrugUnit, item.Quantity, item.PrescriptionID);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();
            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Đồng Bá Thùy";
                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Thuốc";
                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("ĐBT sheet");
                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];
                    // đặt tên cho sheet
                    ws.Name = "Bảng thống kê thuốc đã ra toa";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";
                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Tên thuốc",
                                                "ĐVT",
                                                "Số lượng",
                                                "Mã hóa đơn"
                            };
                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();
                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Bảng thông tin thuốc đã ra toa";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    int colIndex = 1;
                    int rowIndex = 2;
                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
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
                    List<SoldDrug> list = new List<SoldDrug>();
                    // Lặp qua tất cả các dòng trong DataGridView
                    for (int i = 0; i < dgvPrescriptionStatistic.Rows.Count; i++)
                    {
                        string Direction = null;
                        string DrugCost = null;
                        string Price = null;
                        int j = 0;
                        // Tạo một đối tượng Drugs mới từ dữ liệu trong mỗi dòng
                        string DrugName = dgvPrescriptionStatistic.Rows[i].Cells[j++].Value.ToString();
                        string DrugUnit = dgvPrescriptionStatistic.Rows[i].Cells[j++].Value.ToString();
                        string Quantity = dgvPrescriptionStatistic.Rows[i].Cells[j++].Value.ToString();
                        string PrescirptionID = dgvPrescriptionStatistic.Rows[i].Cells[j++].Value.ToString();
                        // Thêm đối tượng Drugs mới vào List
                        list.Add(new SoldDrug(DrugName, DrugUnit, Quantity, Direction, DrugCost,Price, PrescirptionID));
                    }
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in list)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;
                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;
                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugName;
                        ws.Cells[rowIndex, colIndex++].Value = item.DrugUnit;
                        ws.Cells[rowIndex, colIndex++].Value = (item.Quantity);
                        ws.Cells[rowIndex, colIndex++].Value = item.PrescriptionID;
                        /*// lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        ws.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();*/
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }
        }
        #endregion
    }
}
