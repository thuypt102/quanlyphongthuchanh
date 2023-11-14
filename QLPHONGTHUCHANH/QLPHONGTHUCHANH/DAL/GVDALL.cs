using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using QLPHONGTHUCHANH.DTO;
using System.Windows.Forms;

namespace QLPHONGTHUCHANH.DAL
{
    public class GVDALL
    {
        
        private static GVDALL khoitao;
        public static GVDALL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new GVDALL();
                return GVDALL.khoitao;
            }
            private set { GVDALL.khoitao = value; }
        }

        private GVDALL() { }

        public bool timKiem(string idGV)
        {
            string query = "Select * from GIANGVIEN where id = N'" + idGV + "' ";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }
        public List<GV> hienThiGV()
        {
            List<GV> listGV = new List<GV>();

            string query = "Select * from GIANGVIEN ";
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow row in kq.Rows)
            {
                
                string id = row["id"].ToString();
                string tenGV = row["tenGiangVien"].ToString();
                string tenKhoa = row["khoa"].ToString();
                string sdt = row["sdt"].ToString();
                string email = row["email"].ToString();
                int idTaiKhoan = int.Parse(row["idTaiKhoan"].ToString());
                bool? luuTru = row["luuTru"].ToString() == string.Empty ? null : (bool?)row["luuTru"];

                GV GV = new GV(id,tenGV, tenKhoa ,  sdt,email, idTaiKhoan,  luuTru );
                listGV.Add(GV);
            }

            return listGV;
        }


        public bool themGV(string id, string tenGV, string tenKhoa ,string sdt,string email,int idTaiKhoan)
        {
            

            bool luuTru = false;


            string query = "INSERT INTO GIANGVIEN values ('"+ id +"', '" + tenGV + "', '" + tenKhoa + "', '" + sdt + "', '" + email + "', '"
                +   luuTru + "', '" + idTaiKhoan + "')";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq!=null;
        }
        public bool capNhatGV(string id, string tenGV, string tenKhoa, string sdt, int idTaiKhoan)
        {
            

            string query = "UPDATE GIANGVIEN SET tenGiangVien = '" + tenGV + "', khoa = '" + tenKhoa +
       "', sdt = '" + sdt + "', idTaiKhoan = '"+ idTaiKhoan +  "' WHERE id = " + id;


            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }

        public bool xoaGV(string id)
        {
            string query = "DELETE FROM GIANGVIEN WHERE id = " + id;
            int numberOfRowsDeleted = DataProvider.Khoitao.ExecuteNonQuery(query);

            return numberOfRowsDeleted > 0;
        }


        public bool KTtenGV(string id)
        {

            string query = "SELECT * FROM [dbo].[GIANGVIEN] WHERE [id] = "+ id;
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }

        

    }
}
