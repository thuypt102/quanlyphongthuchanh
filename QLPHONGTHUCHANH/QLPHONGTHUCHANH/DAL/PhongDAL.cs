using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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