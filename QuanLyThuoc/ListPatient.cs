using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc
{
    class ListPatient
    {
        #region Fields
        private static ListPatient inStance;
        private List<Patient> listInfoPatient;
        #endregion
        #region Properties
        internal List<Patient> ListInfoPatient { get => listInfoPatient; set => listInfoPatient = value; }

        public static ListPatient Instance
        {
            get
            {
                if (inStance == null)
                    inStance = new ListPatient();
                return inStance;
            }
            set => inStance = value;
        }
        #endregion
        #region Constructor
        private ListPatient()
        {
            ListInfoPatient = new List<Patient>();
        }
        #endregion
    }
}
