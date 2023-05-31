using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DTO
{
    public class AccountDTO
    {
        #region Thuộc tính
        private string id;
        private string displayName;
        private string userName;
        private string password;
        private int type;
        public string Id { get => id; set => id = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
        #endregion
        #region Khai báo
        public AccountDTO(DataRow row)
        {
            this.id = row["id"].ToString();
            this.displayName = row["DisplayName"].ToString();
            this.userName = row["UserName"].ToString();
            this.password = row["UserPass"].ToString();
            this.Type = (int)row["TypeAcc"];
        }

        public AccountDTO(string id, string displayName, string userName, string password, int type)
        {          
            Id = id;
            DisplayName = displayName;
            UserName = userName;
            Password = password;
            Type = type;
        }
        public AccountDTO() { }
        #endregion
    }
}
