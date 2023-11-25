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
            string query = "Select * from LOP where id = '" + idlop + "' ";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }

        public DataTable ShowLopTheoMa(string idlop)
        {
            string query = "Select id, tenLop, tenKhoa, idGiangVienPhuTrach, caLyThuyet, soLuongSinhVien, loaiThucHanh  from LOP where id = '" + idlop + "' ";

            return DataProvider.Khoitao.ExecuteQuery(query);

        }
        public DataTable hienThiLop()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenLop, tenKhoa, idGiangVienPhuTrach, caLyThuyet, soLuongSinhVien, loaiThucHanh from LOP where luuTru =0");
        }

        public bool themLop(string id, string tenlop, string tenKhoa, string idGiangVienPhuTrach,
        string caLyThuyet, int soLuongSinhVien, string loaiThucHanh)
        {


            bool luuTru = false;


            string query = "INSERT INTO LOP values ('" + id + "', N'" + tenlop + "', N'" + tenKhoa + "', '" + idGiangVienPhuTrach + "', '"
                + caLyThuyet + "', '" + soLuongSinhVien + "', N'" + loaiThucHanh + "', '" + luuTru + "')";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }


        public bool capNhatLop(string id, string tenlop, string tenKhoa, string idGiangVienPhuTrach,
        string caLyThuyet, int soLuongSinhVien, string loaiThucHanh)
        {
            string query = "UPDATE LOP SET tenLop = N'" + tenlop +
                "', tenKhoa = N'" + tenKhoa + "', idGiangVienPhuTrach = '" +
                idGiangVienPhuTrach + "', caLyThuyet = '" + caLyThuyet +
                "', soLuongSinhVien = '" + soLuongSinhVien +
                "', loaiThucHanh =N'" + loaiThucHanh + "' WHERE id = '" + id +"'";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }
        public bool KTLienKetLop(string idGV)
        {
            try
            {
                string query = "DELETE FROM LOP WHERE idGiangVienPhuTrach = '" + idGV+"'";
                int numberOfRowsDeleted = DataProvider.Khoitao.ExecuteNonQuery(query);

                return numberOfRowsDeleted > 0;
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public bool xoaLop(string id)
        {
            //try
            {
                string query = "DELETE FROM LOP WHERE id = '" + id + "'";
                int numberOfRowsDeleted = DataProvider.Khoitao.ExecuteNonQuery(query);

                return numberOfRowsDeleted > 0;
            }

            /*catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác (nếu có)
                return false;
            }*/

        }

        public DataTable getDSLop()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenLop, tenKhoa, idGiangVienPhuTrach, caLyThuyet, soLuongSinhVien, loaiThucHanh from LOP where luuTru = 1");
        }
        public bool khoiPhucLop(string id)
        {
            string query = string.Format("UPDATE LOP SET luuTru = 0 WHERE id = '" + id + "'");
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool luuTruLop(string id)
        {
            string query = string.Format("UPDATE LOP SET luuTru = 1 WHERE id =  '" + id + "'");
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
