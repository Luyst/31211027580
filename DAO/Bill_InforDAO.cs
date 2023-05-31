using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DAO
{

    internal class Bill_InforDAO
    {
        #region Instance
        private static Bill_InforDAO instance;
        public static Bill_InforDAO Instance
        {
            get { if (instance == null)instance = new Bill_InforDAO() ; return instance; }
            private set { instance = value; }
        }
        public Bill_InforDAO() { }
        #endregion
        #region InsertBill_Infor
        public void Insert_Bill_Infor(int BillID, string goodID, int Quanlity)
        {
            string query = "EXEC Insert_Bill_Infor @BillID , @gID , @quanlity";
            DataProvider.Instance.ExcuteNonQuery(query,new object[]{BillID,goodID,Quanlity }) ;
        }
        public void AddQuanlityOrder(string gID, int quanlity, int bID)
        {
            string query = "EXEC USP_AddQuanlityOrder @gID , @quanlityADD , @bID";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { gID, quanlity,bID });
        }
        #endregion
    }
}
