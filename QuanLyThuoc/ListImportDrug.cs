using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc
{
    class ListImportDrug
    {
        #region Fields
        private static ListImportDrug inStance;
        private List<ImportDrug> listImportDrug;
        #endregion
        #region Properties
        public static ListImportDrug Instance
        {
            get
            {
                if (inStance == null)
                    inStance = new ListImportDrug();
                return inStance;
            }
            set => inStance = value;
        }

        internal List<ImportDrug> ListImport { get => listImportDrug; set => listImportDrug = value; }
        #endregion
        #region Constructor
        private ListImportDrug()
        {
            ListImport = new List<ImportDrug>();
        }
        #endregion
    }
}
