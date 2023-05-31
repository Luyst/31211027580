using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DTO
{
    internal class GoodsCategoryDTO
    {
        #region Thuộc tính
        private string iD;
        public string ID { get => iD; set => iD = value; }
        private string name;
        public string Name { get => name; set => name = value; }
        #endregion
        #region Khai báo
        public GoodsCategoryDTO(string ID, string Name)
        {
            this.iD = ID;
            this.name = Name;
        }
        public GoodsCategoryDTO(DataRow dataRow)
        {
            this.iD += dataRow["id"].ToString();
            this.name = dataRow["name"].ToString();
        }
        #endregion
    }
}
