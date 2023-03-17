using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc
{
    class Provider
    {
        #region Fields
        private List<string> listProvider;
        private static Provider inStance;
        #endregion
        #region Properties
        public static Provider Instance
        {
            get
            {
                if (inStance == null)
                    inStance = new Provider();
                return inStance;
            }
            set => inStance = value;
        }
        public List<string> ListProvider { get => listProvider; set => listProvider = value; }
        #endregion
        #region Constructor
        public Provider()
        {
           ListProvider  = new List<string>();
            ListProvider.Add("Công ty TNHH Mediphar USA");
            ListProvider.Add("Công ty cổ phần Traphaco");
            ListProvider.Add("Công ty cổ phần dược Hậu Giang");
            ListProvider.Add("Công ty cổ phần dược phẩm Hà Tây");
            ListProvider.Add("Công ty cổ phần hóa dược phẩm Mekophar");
        }
        #endregion
    }
}
