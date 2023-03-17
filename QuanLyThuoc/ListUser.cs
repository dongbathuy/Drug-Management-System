using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc
{
    class ListUser
    {
        #region Fields
        private static ListUser inStance;
        private List<User> listUserName;
        #endregion
        #region Properties
        public List<User> ListUserName { get => listUserName; set => listUserName = value; }
        public static ListUser Instance
        {
            get
            {
                if (inStance == null)
                    inStance = new ListUser();
                return inStance;
            }
            set => inStance = value;
        }
        #endregion
        #region Constructor
        private ListUser()
        {
            // danh sách các account có thể đăng nhập được
            ListUserName = new List<User>();
            ListUserName.Add(new User("dongbathuy", "20206173","Đồng Bá Thùy","20 tuổi","Nam","Hà Nội","12/12"));
            ListUserName.Add(new User("nva", "12345", "Nguyễn Văn A", "35 tuổi","Nam", "Hải Dương", "12/12"));
            ListUserName.Add(new User("a", "a", "Phạm Văn B", "21 tuổi","Nam", "Hải Phòng", "12/12"));
        }
        #endregion
    }
}
