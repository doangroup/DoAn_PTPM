using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ShopQuanAo2.DAO
{
    public class DataProvider
    {
        public string sql = "Data Source = DESKTOP-R95F3JA; Initial Catalog = QLSHOPQUANAO; User ID = sa; Password = taquangtrung";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            //using cho dù có vấn đề j đi nữa khi kết thúc khối lệnh trong đó 
            //dữ liệu khai báo sẽ tự giải phóng
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listpa = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpa)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listpa = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpa)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listpa = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpa)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
