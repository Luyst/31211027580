using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DTO
{
    internal class BillDTO
    {
        #region Thuộc tính
        private int iD;
        private DateTime date;
        private string accID;
        private string customerID;
        public DateTime Date { get => date; set => date = value; }
        public string AID { get => accID; set => accID = value; }
        public string CustomerID { get => CustomerID; set => CustomerID = value; }
        public int ID { get => iD; set => iD = value; }
        #endregion
        #region Khai báo
        public BillDTO() { }
        public BillDTO(int id, string AccID, string CustomerID)
        {
            this.ID = id;
            date = DateTime.Now;
            this.accID = AccID;
            this.customerID = CustomerID;
        }
        public BillDTO(DataRow row)
        {
            this.iD = (int)row["id"];
            date = DateTime.Now;
            accID = row["aID"].ToString();
            customerID = row["CustomerID"].ToString();
        }
        #endregion
    }
}
