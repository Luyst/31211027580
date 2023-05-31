using DoAn_31211027580.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_31211027580.DAO
{
    public class CustomerDAO
    {
        #region Instance
        private static CustomerDAO instance;         
        public static CustomerDAO Instance
        
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; } 
            private set => instance = value;
        }
        public CustomerDAO() { }
        #endregion
        #region GetCustomer
        public List<CustomerDTO> GetCustomerList()
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string query = "SELECT * FROM CUSTOMER";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                CustomerDTO dto = new CustomerDTO(dr);
                list.Add(dto);               
            }       
            return list;           
        }
        #endregion
    }
}
