using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DTO
{
    public class CustomerDTO
    {
        #region Thuộc tính
        private string id;
        private string name;
        private string number;
        private float point;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public float Point { get => point; set => point = value; }
        #endregion
        #region Khai báo
        public CustomerDTO(string Id, string Name, string Number, float Point)
        {
            this.Id = Id;
            this.Name = Name;
            this.Number = Number;
            this.Point = Point;
        }
        public CustomerDTO(DataRow row)
        {
            this.id = row["id"].ToString();
            this.name = row["cName"].ToString();
            this.number = row["cNumber"].ToString();
            this.point = (float)Convert.ToDouble(row["cPoint"]);
        }
        public CustomerDTO() { }
        #endregion





    }
}
