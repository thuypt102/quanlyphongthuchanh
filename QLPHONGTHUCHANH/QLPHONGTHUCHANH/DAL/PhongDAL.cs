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

        public List<Phong> hienThiPhong()
        {
            List<Phong> listPhong = new List<Phong>();

            string query = "SELECT * FROM PHONGMAY";
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow row in kq.Rows)
            {
                string id = row["id"].ToString();
                string tenPhong = row["tenPhong"].ToString();
                string tenKhuVuc = row["tenKhuVuc"].ToString();
                int soLuongMay = int.Parse(row["soLuongMay"].ToString());
                int loaiThucHanh = int.Parse(row["loaiThucHanh"].ToString());
                bool? luuTru = row["luuTru"].ToString() == string.Empty ? null : (bool?)row["luuTru"];

                Phong Phong = new Phong(id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh, luuTru);
                listPhong.Add(Phong);
            }

            return listPhong;
        }

        public bool themPhong(string id, string tenPhong, string tenKhuVuc, int soLuongMay, int loaiThucHanh)
        {
            bool luuTru = false;

            string query = "INSERT INTO PHONGMAY VALUES ('" + id + "', '" + tenPhong + 
                "', '" + tenKhuVuc + "', '" + soLuongMay + "', '" + loaiThucHanh + "', '" + luuTru + "')";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

                return kq != null;
        }

        public bool capNhatPhong(string id, string tenPhong, string tenKhuVuc, int soLuongMay, int loaiThucHanh)
        {
            string query = "UPDATE PHONGMAY SET tenPhong = '" + tenPhong + "', tenKhuVuc = '" + tenKhuVuc +
                "', soLuongMay = " + soLuongMay + ", loaiThucHanh = " + loaiThucHanh + " WHERE id = '" + id + "'";

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

    }

    }

