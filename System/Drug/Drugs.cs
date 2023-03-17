using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc {
    public class Drugs {
        #region Fields
        private string drugId;
        private string drugName; // tên thuốc
        private string drugIngredient; // thành phần thuốc
        private string drugEffect; // tác dụng của thuốc
        private string drugUnit; // đơn vị thuốc ( Viên/Lọ)
        private string quantity; // số lượng hiện có
        private string drugCost; // giá thuốc
        #endregion
        #region Properties
        public string DrugID { get => drugId; set => drugId = value; }
        public string DrugName { get => drugName; set => drugName = value; }
        public string DrugIngredient { get => drugIngredient; set => drugIngredient = value; }
        public string DrugEffect { get => drugEffect; set => drugEffect = value; }
        public string DrugUnit { get => drugUnit; set => drugUnit = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string DrugCost { get => drugCost; set => drugCost = value; }

        #endregion
        #region Constructor
        public Drugs(string iDrugID, string iDrugName, string iDrugIngredient
            , string iDrugEffect, string iDrugUnit, string iQuantity, string iDrugCost) {
            this.DrugID = iDrugID;
            this.DrugName = iDrugName;
            this.DrugIngredient = iDrugIngredient;
            this.DrugEffect = iDrugEffect;
            this.DrugUnit = iDrugUnit;
            this.Quantity = iQuantity;
            this.DrugCost = iDrugCost;
        }
        #endregion

    }
}
