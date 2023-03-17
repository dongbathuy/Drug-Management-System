using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc
{
    class ListDrug
    {
        #region Fields
        private static ListDrug inStance;
        private List<Drugs> listDrugs;
        #endregion
        #region Properties
        public List<Drugs> ListDrugs { get => listDrugs; set => listDrugs = value; }
        public static ListDrug Instance
        {
            get
            {
                if (inStance == null)
                    inStance = new ListDrug();
                return inStance;
            }
            set => inStance = value;
        }
        #endregion
        #region Constructor
        private ListDrug()
        {
            ListDrugs = new List<Drugs>();
                try
                {
                    // mở file excel
                    var package = new ExcelPackage(new FileInfo(@"ListDrug.xlsx"));

                    // lấy ra sheet đầu tiên để thao tác
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[0];

                    // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                    for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            // biến j biểu thị cho một column trong file
                            int j = 1;

                            // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                            // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                            string DrugID = workSheet.Cells[i,j++].Value.ToString();
                            string DrugName = workSheet.Cells[i,j++].Value.ToString();
                            string DrugIngredient = workSheet.Cells[i,j++].Value.ToString();
                            string DrugEffect = workSheet.Cells[i,j++].Value.ToString();
                            string DrugUnit = workSheet.Cells[i,j++].Value.ToString();
                            string QuantityAvailable = workSheet.Cells[i,j++].Value.ToString();
                            string DrugCost = workSheet.Cells[i,j++].Value.ToString();


                            ListDrugs.Add(new Drugs(DrugID, DrugName, DrugIngredient, DrugEffect, DrugUnit, QuantityAvailable, DrugCost));

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error!");
                }
        }
        #endregion
    }
}
