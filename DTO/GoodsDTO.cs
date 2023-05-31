using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DTO
{
    public  class GoodsDTO
    {
        #region Thuộc tính

        private string iD;
        public string ID
        {
            get => iD;
            set => iD = value;
        }
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        private string type;
        public string Type
        {
            get => type;
            set => type = value;
        }
        private string dVT;

        public string DVT
        {
            get => dVT;
            set => dVT = value;
        }
        private float price;
        public float Price
        {
            get => price;
            set => price = value;
        }
        #endregion
        #region Khai báo
        public GoodsDTO(string ID, string Name, string Type, string DVT, float Price)
        {
            this.iD = ID;
            this.name = Name;
            this.type = Type;
            this.dVT = DVT;
            this.price = Price;
        }

        public GoodsDTO(DataRow dataRow)
        {
            this.iD = dataRow["id"].ToString();
            this.name = dataRow["Tên sản phẩm"].ToString();
            this.type = dataRow["Loại"].ToString();
            this.dVT = dataRow["DVT"].ToString();
            this.price = (float)Convert.ToInt32(dataRow["Đơn giá"]);
        }
        public GoodsDTO() { }
        #endregion
    }
}
