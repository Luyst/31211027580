using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DTO
{
    internal class Bill_InforDTO
    {
        #region Thuộc tính
        private string billID;
        private string goodID;
        private int quanlity;
        public string BillID { get => billID; set => billID = value; }
        public string GoodID { get => goodID; set => goodID = value; }
        public int Quanlity { get => quanlity; set => quanlity = value; }
        #endregion
        #region Khai báo
        public Bill_InforDTO() { }
        public Bill_InforDTO(string billID, string goodID, int quanlity)
        {
            BillID = billID;
            GoodID = goodID;
            Quanlity = quanlity;
        }
        #endregion
    }
}
