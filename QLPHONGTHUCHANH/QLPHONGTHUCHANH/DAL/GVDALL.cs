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

        public DataTable hienThiGV()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenGiangVien, khoa, sdt, email, idTaiKhoan from GIANGVIEN where luuTru = 0");
        }

        public DataTable ShowGVTheoMa(string idGV)
        {
            string query = "Select id, tenGiangVien, khoa, sdt, email, idTaiKhoan  from GIANGVIEN where id = '" + idGV + "' ";
            return DataProvider.Khoitao.ExecuteQuery(query);
        }

        public bool themGV(string id, string tenGV, string tenKhoa, string sdt, string email, int idTaiKhoan)
        {
            bool luuTru = false;
            string query = "";
            if (idTaiKhoan != 0)
            {
                query = "INSERT INTO GIANGVIEN values ('" + id + "', '" + tenGV + "', '" + tenKhoa + "', '" + sdt + "', '" + email + "', '"
               + luuTru + "', '" + idTaiKhoan + "')";
            }
            else
            {
                query = "INSERT INTO GIANGVIEN VALUES ('" + id + "', N'" + tenGV + "', N'" +
                    tenKhoa + "', '" + sdt + "', '" + email + "', '" + luuTru + "', NULL)";
            }
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }

        public DataTable getDSgv()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenGiangVien, khoa, sdt, email, idTaiKhoan from GIANGVIEN where luuTru = 1");
        }

        public bool capNhatGV(string id, string tenGV, string tenKhoa, string sdt, string email, int idTaiKhoan)
        {

            string query = "";
            if (idTaiKhoan != 0)
            {
                query = "UPDATE GIANGVIEN SET tenGiangVien = N'" + tenGV +
                    "', khoa = N'" + tenKhoa + "', sdt = '" + sdt +
                    "', email = '" + email + "', idTaiKhoan = '" +
                    idTaiKhoan + "' WHERE id = " + id;
            }
            else
            {
                query = "UPDATE GIANGVIEN SET tenGiangVien = N'" + tenGV +
                    "', khoa = N'" + tenKhoa + "', sdt = '" + sdt +
                    "', email = '" + email +
                    "', idTaiKhoan = NULL WHERE id = '" + id + "'";
            }

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }

        public bool xoaGV(string id)
        {

            try
            {
                string query = "DELETE FROM GIANGVIEN WHERE id = " + id;
                int numberOfRowsDeleted = DataProvider.Khoitao.ExecuteNonQuery(query);

                return numberOfRowsDeleted > 0;
            }

            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác (nếu có)
                return false;
            }

        }
        public bool KTLienKet(string id)
        {

            try
            {
                string query = "DELETE FROM GIANGVIEN WHERE id = " + id;
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
        

        public bool KTtenGV(string id)
        {

            string query = "SELECT * FROM [dbo].[GIANGVIEN] WHERE [id] = "+ id;
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }

        public bool khoiPhucGiangVien(string id)
        {
            string query = string.Format("UPDATE GIANGVIEN SET luuTru = 0 WHERE id = " + id);
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool luuTruGiangVien(string id)
        {
            string query = string.Format("UPDATE GIANGVIEN SET luuTru = 1 WHERE id = " + id);
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
