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
    public class GVDAL
        
    {
        
        private static GVDAL khoitao;
        public static GVDAL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new GVDAL();
                return GVDAL.khoitao;
            }
            private set { GVDAL.khoitao = value; }
        }

        /*private GVDAL() { }

        public bool timKiem(string idlop)
        {
            string query = "Select * from  where tenDangNhap = N'" + idlop + "' ";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }
        public List<Lop> hienThiLop()
        {
            List<Lop> listlop = new List<Lop>();

            string query = "Select * from LOP ";
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow row in kq.Rows)
            {
                
                string id = row["id"].ToString();
                string tenlop = row["tenLop"].ToString();
                string tenKhoa = row["tenKhoa"].ToString();
                string idGiangVienPhuTrach = row["idGiangVienPhuTrach"].ToString();
                string caLyThuyet = row["caLyThuyet"].ToString();
                int soLuongSinhVien = int.Parse(row["soLuongSinhVien"].ToString());
                int loaiThucHanh =int.Parse(row["loaiThucHanh"].ToString());
                bool? luuTru = row["luuTru"].ToString() == string.Empty ? null : (bool?)row["luuTru"];

                Lop lop = new Lop(id,tenlop, tenKhoa , idGiangVienPhuTrach , caLyThuyet,
                    soLuongSinhVien, loaiThucHanh , luuTru );
                listlop.Add(lop);
            }

            return listlop;
        }


        public bool themLop(string id, string tenlop, string tenKhoa, string idGiangVienPhuTrach ,
        string caLyThuyet, int soLuongSinhVien, int loaiThucHanh)
        {
            

            bool luuTru = false;


            string query = "INSERT INTO LOP values ('"+ id +"', '" + tenlop + "', '" + tenKhoa + "', '" + idGiangVienPhuTrach + "', '"
                + caLyThuyet + "', '" + soLuongSinhVien + "', '" + loaiThucHanh + "', '" + luuTru + "')";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq!=null;
        }
        public bool capNhatLop(string id, string tenlop, string tenKhoa, string idGiangVienPhuTrach,
        string caLyThuyet, int soLuongSinhVien, int loaiThucHanh)
        {
            

            string query = "UPDATE LOP SET tenLop = '" + tenlop + "', tenKhoa = '" + tenKhoa +
       "', idGiangVienPhuTrach = '" + idGiangVienPhuTrach + "', caLyThuyet = '"
       + caLyThuyet + "', soLuongSinhVien = " + soLuongSinhVien +
       ", loaiThucHanh ='" + loaiThucHanh + "' WHERE id = " + id;


            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }

        public bool xoaLop(string id)
        {
            string query = "DELETE FROM LOP WHERE id = " + id;
            int numberOfRowsDeleted = DataProvider.Khoitao.ExecuteNonQuery(query);

            return numberOfRowsDeleted > 0;
        }*/

    }
}
