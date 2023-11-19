using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPHONGTHUCHANH.DTO;

namespace QLPHONGTHUCHANH.DAL
{
    public class PhongDAL
    {
       
            private static PhongDAL khoitao;
            public static PhongDAL Khoitao
            {
                get
                {
                    if (khoitao == null)
                        khoitao = new PhongDAL();
                    return PhongDAL.khoitao;
                }
                private set { PhongDAL.khoitao = value; }
            }

            private PhongDAL() { }

            public bool timKiem(string idPhong)
            {
                string query = "SELECT * FROM PHONGMAY WHERE id = '" + idPhong + "'";

                DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
                return kq.Rows.Count > 0;
            }

        public DataTable hienThiPhong()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh from PHONGMAY where luuTru = 0");
        }

        public bool themPhong(string id, string tenPhong, string tenKhuVuc, int soLuongMay, string loaiThucHanh)
        {
            bool luuTru = false;

            string query = "INSERT INTO PHONGMAY VALUES ('" + id + "', '" + tenPhong + 
                "', '" + tenKhuVuc + "', '" + soLuongMay + "', N'" + loaiThucHanh + "', '" + luuTru + "')";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

                return kq != null;
        }

        public bool capNhatPhong(string id, string tenPhong, string tenKhuVuc, int soLuongMay, string  loaiThucHanh)
        {
            string query = "UPDATE PHONGMAY SET tenPhong = N'" + tenPhong + "', tenKhuVuc = '" + tenKhuVuc +
                "', soLuongMay = '" + soLuongMay + "', loaiThucHanh = N'"
 + loaiThucHanh + "' WHERE id = '" + id + "'";

            //string query = "UPDATE PHONGMAY SET tenPhong = @TenPhong, tenKhuVuc = @TenKhuVuc, soLuongMay = @SoLuongMay, loaiThucHanh = @LoaiThucHanh WHERE id = @ID";
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }

        public bool xoaPhong(string id)
        {
            string query = "DELETE FROM PHONGMAY WHERE id = '" + id + "'";
            int numberOfRowsDeleted = DataProvider.Khoitao.ExecuteNonQuery(query);

            return numberOfRowsDeleted > 0;
        }


        public DataTable getDSPhong()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh from PHONGMAY where luuTru = 1");
        }
        public bool khoiPhucPhong(string id)
        {
            string query = string.Format("UPDATE PHONGMAY SET luuTru = 0 WHERE id = " + id);
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool luuTruPhong(string id)
        {
            string query = string.Format("UPDATE PHONGMAY SET luuTru = 1 WHERE id = " + id);
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

