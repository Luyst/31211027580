using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DAO
{
    internal class DoanhThuDAO
    {
        #region Instance
        private static DoanhThuDAO instance;
        public static DoanhThuDAO Instance
        {
            get {if(instance ==null)instance=new DoanhThuDAO(); return instance; }
            private set { instance = value; }
        }
        public DoanhThuDAO() { }
        #endregion
        #region Query
        public DataTable DoanhThuTable()
        {
            string query = "EXEC USP_BillDoanhThu";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);         
            return dt;
        }
        public DataTable FindBillByDate(DateTime date) 
        {
            string query = "EXEC USP_FindBillByDate @date ";
            return DataProvider.Instance.ExcuteQuery(query,new object[] {date});
        }
        public DataTable BillList()
        {
            DataTable dt = new DataTable();
            return dt;  
        }
        public int DoanhThuPerson(string userName,string password)
        {
            string accID = AccountDAO.Instance.AccCurrent(userName,password).Id.ToString();
            string query = "EXEC USP_DoanhThuPerson @accID ";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query,new object[] {accID});

            return Convert.ToInt32(dt.Rows[0]["Thành tiền"]);
        }
        #endregion
    }
}
