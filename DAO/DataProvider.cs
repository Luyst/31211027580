using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAn_31211027580.DAO
{
    public class DataProvider
    {
        #region Instance
        private static DataProvider instance;
        public static DataProvider Instance 
        {
            get { if (instance == null)  instance = new DataProvider();return DataProvider.instance; }
            private set => DataProvider.instance = value;
        }
        public DataProvider() { }
        #endregion
        #region SQL_Query
        private string conectionSTR = "Data Source=.\\MSSQLSERVER01;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conection = new SqlConnection(conectionSTR))
            {
                conection.Open();
                SqlCommand cmd = new SqlCommand(query, conection);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int count = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[count]);
                            count++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conection = new SqlConnection(conectionSTR))
            {
                conection.Open();
                SqlCommand cmd = new SqlCommand(query, conection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int count = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[count]);
                            count++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                conection.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conection = new SqlConnection(conectionSTR))
            {
                conection.Open();
                SqlCommand cmd = new SqlCommand(query, conection);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int count = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[count]);
                            count++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                conection.Close();
            }
            return data;
        }
        #endregion
    }
}
