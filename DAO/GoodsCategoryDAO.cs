using DoAn_31211027580.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DAO
{
    internal class GoodsCategoryDAO
    {
        #region Instance
        private static GoodsCategoryDAO instance;
        public static GoodsCategoryDAO Instance 
        {

            get {if(instance == null)instance=new GoodsCategoryDAO() ; return instance; } 
            private set => instance = value;
        }
        public GoodsCategoryDAO() { }
        #endregion
        #region Query
        public List<GoodsCategoryDTO> GetListCategory()
        {
            List<GoodsCategoryDTO> list = new List<GoodsCategoryDTO>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("Select * from GoodsCategory");
            foreach(DataRow row in dataTable.Rows )
            {
                GoodsCategoryDTO goodsCategory = new GoodsCategoryDTO(row);
                list.Add(goodsCategory);
            }
            return list;
        }
        #endregion
    }
}
