using DoAn_31211027580.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_31211027580.DAO
{
    public class AccountDAO
    {
        #region Instance
        private static AccountDAO instance;
        internal static AccountDAO Instance 
        {
            get { if (instance == null) { instance = new AccountDAO(); } return instance; }
            private set => instance = value; 
        }
        private AccountDAO() { }
        #endregion
        #region CheckAcc
        public bool LoginAccept(string username, string password)
        {
            string query = $"SELECT * FROM ACCOUNT WHERE UserName='{username}' and UserPass='{password}'";
            DataTable check =DataProvider.Instance.ExcuteQuery(query);
            string checkName ="", checkPassword="";
            foreach(DataRow row in check.Rows)
            {
                checkName = row["UserName"].ToString();
                checkPassword = row["UserPass"].ToString();
            }
            return checkName==username && checkPassword==password;
        }
        public bool CheckAdmin(string username, string password)
        {
            string query = $"SELECT * FROM ACCOUNT WHERE UserName='{username}' and UserPass='{password}'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            int check;
            check = (int)dt.Rows[0]["TypeAcc"];
            return check == 1;    // 1 <=> Admin
        }
        #endregion
        #region GetAcc
        public AccountDTO AccCurrent(string username, string password =null )
        {
            string query;
            if (password == null)
            {
                query = $"SELCET * FROM ACCOUNT WHERE UserName='{username}'";
            }
            else
            {
                query = $"SELECT * FROM ACCOUNT WHERE UserName='{username}' and UserPass='{password}'";
            }
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            AccountDTO account = new AccountDTO(data.Rows[0]);
            return account;
        }
        public DataTable GetAccounts()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("EXEC USP_AccList");
            dt.Columns.Add("Type", typeof(string));
            foreach(DataRow row in dt.Rows)
            {
                if ((int)row["Loại"]==0)
                {
                    row["Type"] = "Nhân viên";
                }
                else
                {
                    row["Type"] = "Quản lý";
                }
            }
            dt.Columns.Remove("Loại");
            return dt;
        }
        #endregion
        #region ChangePass
        public bool ChangePass(string username, string newpass)
        {
            string query = "EXEC USP_ChangePass  @username , @newPass";
            int done = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username, newpass });
            return done == 1;
        }
        #endregion
    }
}