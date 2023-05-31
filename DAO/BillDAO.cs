using DoAn_31211027580.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DAO
{
    internal class BillDAO
    {
        #region Instance
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public BillDAO() { }
        #endregion
        #region InsertBill
        public void BillInssert (string accID, string cusID = "none")
        {
            string query = "EXEC USP_InsertBill @aId , @cusID";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { accID, cusID });
        }
        public BillDTO GetCurrentBill()
        {
            string query = "select* from BILL where ID=(select max(id)from bill)";
            BillDTO dto = new BillDTO(DataProvider.Instance.ExcuteQuery(query).Rows[0]);         
            return dto;
        }
        #endregion
    }
}
