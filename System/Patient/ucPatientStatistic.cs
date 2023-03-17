using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using QuanLyThuoc.CreateOrReset;

namespace QuanLyThuoc {
    public partial class ucPatientStatistic : UserControl, ICreate {
        public ucPatientStatistic() {
            InitializeComponent();
        }
        #region Methods
        public void CreateColumnForDataGridView()// tạo cột
        {
            var colPrescriptionID = new DataGridViewTextBoxColumn();
            var colPrescriptionDate = new DataGridViewTextBoxColumn();
            var colPatientName = new DataGridViewTextBoxColumn();
            var colPatientDateBirth = new DataGridViewTextBoxColumn();
            var colPatientPhoneNumber = new DataGridViewTextBoxColumn();
            var colPatientAddress = new DataGridViewTextBoxColumn();
            var colDiagnostic = new DataGridViewTextBoxColumn();

            colPrescriptionID.HeaderText = " Mã hóa đơn";
            colPrescriptionDate.HeaderText = "Ngày ra toa";
            colPatientName.HeaderText = "Họ tên";
            colPatientDateBirth.HeaderText = "Ngày sinh";
            colPatientPhoneNumber.HeaderText = "Số điện thoại";
            colPatientAddress.HeaderText = "Địa chỉ";
            colDiagnostic.HeaderText = "Chuẩn đoán";

            colPrescriptionID.DataPropertyName = "PrescriptionID";
            colPrescriptionDate.DataPropertyName = "PrescriptionDate";
            colPatientName.DataPropertyName = "PatientName";
            colPatientDateBirth.DataPropertyName = "PatientDateBirth";
            colPatientPhoneNumber.DataPropertyName = "PatientPhoneNumber";
            colPatientAddress.DataPropertyName = "PatientAddress";
            colDiagnostic.DataPropertyName = "Diagnostic";
            dgvPatientStatistic.Columns.AddRange(new DataGridViewColumn[] {colPrescriptionID, colPrescriptionDate, colPatientName, colPatientDateBirth, colPatientPhoneNumber
            , colPatientAddress, colDiagnostic});
        }
        public void LoadListPatient() {
            dgvPatientStatistic.DataSource = ListPatient.Instance.ListInfoPatient;
        }
        #endregion
        #region Events
        private void userControlPatientStatistic_Load(object sender, EventArgs e) {
            CreateColumnForDataGridView();
            LoadListPatient();
        }

        private void btnAll_Click(object sender, EventArgs e) {
            dgvPatientStatistic.DataSource = null;
            CreateColumnForDataGridView();
            LoadListPatient();
            cbFind.Text = null;
            txbFind.Text = null;
        }

        private void txbFind_TextChanged(object sender, EventArgs e) {
            if (cbFind.Text == "Mã hóa đơn") {
                List<Patient> listInfoPatient = new List<Patient>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListPatient.Instance.ListInfoPatient) {
                    if (item.PrescriptionID == txbFind.Text) {
                        listInfoPatient.Add(item);
                    }
                }
                dgvPatientStatistic.DataSource = null;
                CreateColumnForDataGridView();
                dgvPatientStatistic.DataSource = listInfoPatient;
            }
            else if (cbFind.Text == "Ngày ra toa") {
                List<Patient> listInfoPatient = new List<Patient>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListPatient.Instance.ListInfoPatient) {
                    if (item.PrescriptionDate == txbFind.Text) {
                        listInfoPatient.Add(item);
                    }
                }
                dgvPatientStatistic.DataSource = null;
                CreateColumnForDataGridView();
                dgvPatientStatistic.DataSource = listInfoPatient;
            }
            else if (cbFind.Text == "Họ tên") {
                List<Patient> listInfoPatient = new List<Patient>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListPatient.Instance.ListInfoPatient) {
                    if (item.PatientName == txbFind.Text) {
                        listInfoPatient.Add(item);
                    }
                }
                dgvPatientStatistic.DataSource = null;
                CreateColumnForDataGridView();
                dgvPatientStatistic.DataSource = listInfoPatient;
            }
            else if (cbFind.Text == "Ngày sinh") {
                List<Patient> listInfoPatient = new List<Patient>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListPatient.Instance.ListInfoPatient) {
                    if (item.PatientDateBirth == txbFind.Text) {
                        listInfoPatient.Add(item);
                    }
                }
                dgvPatientStatistic.DataSource = null;
                CreateColumnForDataGridView();
                dgvPatientStatistic.DataSource = listInfoPatient;
            }
            else if (cbFind.Text == "Số điện thoại") {
                List<Patient> listInfoPatient = new List<Patient>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListPatient.Instance.ListInfoPatient) {
                    if (item.PatientPhoneNumber == txbFind.Text) {
                        listInfoPatient.Add(item);
                    }
                }
                dgvPatientStatistic.DataSource = null;
                CreateColumnForDataGridView();
                dgvPatientStatistic.DataSource = listInfoPatient;
            }
            else if (cbFind.Text == "Địa chỉ") {
                List<Patient> listInfoPatient = new List<Patient>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListPatient.Instance.ListInfoPatient) {
                    if (item.PatientAddress == txbFind.Text) {
                        listInfoPatient.Add(item);
                    }
                }
                dgvPatientStatistic.DataSource = null;
                CreateColumnForDataGridView();
                dgvPatientStatistic.DataSource = listInfoPatient;
            }
            else if (cbFind.Text == "Chuẩn đoán") {
                List<Patient> listInfoPatient = new List<Patient>(); // tạo một danh sách phụ để lưu
                foreach (var item in ListPatient.Instance.ListInfoPatient) {
                    if (item.Diagnostic == txbFind.Text) {
                        listInfoPatient.Add(item);
                    }
                }
                dgvPatientStatistic.DataSource = null;
                CreateColumnForDataGridView();
                dgvPatientStatistic.DataSource = listInfoPatient;
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
                    ws.Name = "Bảng thống kê bệnh nhân";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";
                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                        "Mã hóa đơn",
                        "Ngày ra toa",
                        "Họ tên",
                        "Ngày sinh",
                        "Số điện thoại",
                        "Địa chỉ",
                        "Chuẩn đoán"
                            };
                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();
                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Bảng thống kê bệnh nhân";
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
                    List<Patient> list = new List<Patient>();
                    // Lặp qua tất cả các dòng trong DataGridView
                    for (int i = 0; i < dgvPatientStatistic.Rows.Count; i++) {
                        int j = 0;
                        // Tạo một đối tượng DrugImport mới từ dữ liệu trong mỗi dòng
                        string PrescriptionID = dgvPatientStatistic.Rows[i].Cells[j++].Value.ToString();
                        string PrescriptionDate = dgvPatientStatistic.Rows[i].Cells[j++].Value.ToString();
                        string PatientName = dgvPatientStatistic.Rows[i].Cells[j++].Value.ToString();
                        string PatientDateBirth = dgvPatientStatistic.Rows[i].Cells[j++].Value.ToString();
                        string PatientPhoneNumber = dgvPatientStatistic.Rows[i].Cells[j++].Value.ToString();
                        string PatientAddress = dgvPatientStatistic.Rows[i].Cells[j++].Value.ToString();
                        string Diagnostic = dgvPatientStatistic.Rows[i].Cells[j++].Value.ToString();

                        // Thêm đối tượng Drugs mới vào List
                        list.Add(new Patient(PrescriptionID, PrescriptionDate, PatientName, PatientPhoneNumber
                            , PatientDateBirth, PatientAddress, Diagnostic));
                    }
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in list) {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;
                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;
                        //gán giá trị cho từng cell
                        //
                        ws.Cells[rowIndex, colIndex++].Value = item.PrescriptionID;
                        ws.Cells[rowIndex, colIndex++].Value = item.PrescriptionDate;
                        ws.Cells[rowIndex, colIndex++].Value = item.PatientName;
                        ws.Cells[rowIndex, colIndex++].Value = (item.PatientPhoneNumber);
                        ws.Cells[rowIndex, colIndex++].Value = item.PatientDateBirth;
                        ws.Cells[rowIndex, colIndex++].Value = item.PatientAddress;
                        ws.Cells[rowIndex, colIndex++].Value = item.Diagnostic;
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
    }
}
