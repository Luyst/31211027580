using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_31211027580.DAO
{
    internal class OrderDAO
    {
        #region Instance
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get { if(instance==null) instance=new OrderDAO(); return instance; }
            private set { instance = value; }
        }
        public OrderDAO() { }
        #endregion
        #region Query
        public DataTable GetOrder(int id) 
        {
            string query = "EXEC USP_Order @billID ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { id });
        }
        public double TotalOrder(int id)
        {
            string query = "EXEC USP_TotalOrder @bID ";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query,new object[]{ id});
            DataRow dr = dataTable.Rows[0];
            double total = Convert.ToDouble(dr["Thành tiền"]);
            return total;
        }
        #endregion
    }
}
