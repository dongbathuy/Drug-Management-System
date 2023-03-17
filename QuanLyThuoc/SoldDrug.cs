using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc
{
    public class SoldDrug
    {
        #region Fields
        private string drugName; // tên thuốc
        private string drugUnit; // đơn vị thuốc ( Viên/Lọ)
        private string quantity; // số lượng
        private string direction;
        private string drugCost; // giá thuốc
        private string price;
        private string prescriptionID;
        #endregion
        #region Properties
        public string DrugName { get => drugName; set => drugName = value; }
        public string DrugUnit { get => drugUnit; set => drugUnit = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Direction { get => direction; set => direction = value; }
        public string DrugCost { get => drugCost; set => drugCost = value; }
        public string PrescriptionID { get => prescriptionID; set => prescriptionID = value; }
        public string Price { get => price; set => price = value; }
        #endregion
        #region Constructor
        public SoldDrug(string iDrugName, string iDrugUnit, string iQuantity,string iDirection
            , string iDrugCost,string iPrice, string iPrescriptionID)
        {
            this.DrugName = iDrugName;
            this.DrugUnit = iDrugUnit;
            this.Quantity = iQuantity;
            this.Direction = iDirection;
            this.DrugCost = iDrugCost;
            this.Price = iPrice;
            this.PrescriptionID = iPrescriptionID;
        }
        #endregion

    }
}
