using DoAn_31211027580.DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DAO
{
    public class GoodsDAO
    {
        #region Instance
        private static GoodsDAO instance;
        public static GoodsDAO Instance
        {
            get {if(instance==null)instance=new GoodsDAO(); return instance; }
            private set { instance = value; }
        }
        public GoodsDAO() { }
        #endregion
        #region GetGoods
        public List<GoodsDTO> GetGoodsList()
        {
            List<GoodsDTO> list = new List<GoodsDTO>();
            DataTable goodsTable= DataProvider.Instance.ExcuteQuery("EXEC USP_GetGoodsList");
            foreach (DataRow row in goodsTable.Rows)
            {
                GoodsDTO goods = new GoodsDTO(row);
                list.Add(goods);
            }
            return list;
        }
        public GoodsDTO GetGoods(string name)
        {
            GoodsDTO good = new GoodsDTO();
            string query = "EXEC USP_GetGood @goodName";
            DataTable goodlist = DataProvider.Instance.ExcuteQuery(query, new object[] { name });
            foreach (DataRow row in goodlist.Rows)
            {
                good = new GoodsDTO(row);
            }
            return good;
        }
        #endregion
        #region GetMenu

        public DataTable GetMenuList()
        {
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("EXEC USP_GetGoodsList");
            return dataTable;
        }
        public DataTable GetMenuListByCategory(string CateName)
        {
            string query = "EXEC USP_GetGoodsListByCategory @CateName ";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query,new object[] {CateName});
            return dataTable;
        }
        public DataTable GetMenuByName(string GoodName)
        {
            return DataProvider.Instance.ExcuteQuery("EXEC USP_GetGoodsListByGoodName @goodname", new object[] { GoodName });
        }
        #endregion
    }
}
