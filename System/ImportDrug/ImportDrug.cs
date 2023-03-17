using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc {
    public class ImportDrug : Drugs {
        #region Fields
        private string importID; // mã hóa đơn
        private string importDate; // ngày nhập 
        private string provider; // nhà cung cấp
        #endregion
        #region Properties
        public string ImportID { get => importID; set => importID = value; }
        public string ImportDate { get => importDate; set => importDate = value; }
        public string Provider { get => provider; set => provider = value; }
        #endregion
        #region Constructor
        public ImportDrug(string iImportID, string iImportDate, string iProvider, string iDrugID
            , string iDrugName, string iDrugIngredient, string iDrugEffect, string iDrugUnit, string iQuantity
            , string iDrugCost) : base(iDrugID, iDrugName, iDrugIngredient, iDrugEffect, iDrugUnit, iQuantity, iDrugCost) {
            this.ImportID = iImportID;
            this.importDate = iImportDate;
            this.Provider = iProvider;
        }
        #endregion
    }
}
