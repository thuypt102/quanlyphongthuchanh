using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace QLPHONGTHUCHANH.DAL
{
    public class LopDAL
    {
        
        private static LopDAL khoitao;
        public static LopDAL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new LopDAL();
                return LopDAL.khoitao;
            }
            private set { LopDAL.khoitao = value; }
        }

        private LopDAL() { }

        public bool timKiem(string idlop)
        {
            string query = "Select * from LOP where tenDangNhap = N'" + idlop + "' ";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }
        /*public List<LopDAL> hienThiLop()
        {
            List<LopDAL> listlop= new List<LopDAL>();

            string query = "Select * from LOP ";
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            foreach (DataRow row in kq.Rows)
            {
                string id  = row["ID"].ToString();
                string name = row["Name"].ToString();

                LopDAL lop = new LopDAL(id, name);
                listlop.Add(lop);
            }
            
            return listlop;
        }*/


        
    }
}
