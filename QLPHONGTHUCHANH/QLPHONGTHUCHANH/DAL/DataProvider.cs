using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DAL
{
    public class DataProvider
    {
        private static DataProvider khoitao;

        public static DataProvider Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new DataProvider();
                return DataProvider.khoitao;
            }
            private set { DataProvider.khoitao = value; }
        }

        private DataProvider() { }

        private string connstr = @"Data Source=THUYPT-LAPTOP\THUYPT;Initial Catalog=QLPTH;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] thamSo = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(connstr)) //tu giai phong khi ket thuc khối lệnh
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int i = 0;
                if (thamSo != null)
                {
                    string[] dsThamSo = query.Split(' ');

                    foreach (string item in dsThamSo)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, dsThamSo[i]);
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

        public int ExecuteNonQuery(string query, object[] thamSo = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(connstr)) //tu giai phong khi ket thuc khối lệnh
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int i = 0;
                if (thamSo != null)
                {
                    string[] dsThamSo = query.Split(' ');

                    foreach (string item in dsThamSo)
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, dsThamSo[i]);
                            i++;
                        }
                }

                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] thamSo = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(connstr)) //tu giai phong khi ket thuc khối lệnh
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int i = 0;
                if (thamSo != null)
                {
                    string[] dsThamSo = query.Split(' ');

                    foreach (string item in dsThamSo)
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, dsThamSo[i]);
                            i++;
                        }
                }

                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
