using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc {
    class ListSoldDrug {
        #region Fields
        private static ListSoldDrug inStance;
        private List<SoldDrug> listSold;
        #endregion
        #region Properties
        public static ListSoldDrug Instance {
            get {
                if (inStance == null)
                    inStance = new ListSoldDrug();
                return inStance;
            }
            set => inStance = value;
        }

        internal List<SoldDrug> ListSold { get => listSold; set => listSold = value; }
        #endregion
        #region Constructor
        private ListSoldDrug() {
            ListSold = new List<SoldDrug>();
        }
        #endregion
    }
}
