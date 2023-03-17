namespace QuanLyThuoc {
    class User {
        #region Fields
        private string userName;
        private string passWord;
        private string name;
        private string age;
        private string sex;
        private string address;
        private string level;
        #endregion
        #region Properties
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string Level { get => level; set => level = value; }
        public string Sex { get => sex; set => sex = value; }
        #endregion
        #region Constructor
        public User(string iUserName, string iPassWord, string iName
            , string iAge, string iSex, string iAddress, string iLevel) {
            this.UserName = iUserName;
            this.PassWord = iPassWord;
            this.Name = iName;
            this.Age = iAge;
            this.Sex = iSex;
            this.Address = iAddress;
            this.Level = iLevel;
        }
        #endregion
    }
}
