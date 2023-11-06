using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DAL
{
    public class TaiKhoanDAL
    {
        private static TaiKhoanDAL khoitao;

        public static TaiKhoanDAL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new TaiKhoanDAL();
                return TaiKhoanDAL.khoitao;
            }
            private set { TaiKhoanDAL.khoitao = value; }
        }

        private TaiKhoanDAL() { }

        public bool kiemTra(string user, string pass)
        {
            string query = "Select * from TAIKHOAN where tenDangNhap = N'" + user + "' and matKhau = N'" + pass + "' ";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);
            return kq.Rows.Count > 0;
        }

        public bool getType(string user, string pass)
        {
            string query = "Select loaiTaiKhoan from TAIKHOAN where tenDangNhap = N'" + user + "' and matKhau = N'" + pass + "' ";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            if (kq.Rows.Count > 0)
            {
                return Convert.ToBoolean(kq.Rows[0]["loaiTaiKhoan"]);
            }

            // Trường hợp không tìm thấy dữ liệu hoặc lỗi xảy ra, bạn có thể xử lý và trả về một giá trị mặc định khác
            return false;
        }
        public DataTable getGiangVienInfo(string user, string pass)
        {
            string query = "SELECT G.id, G.tenGiangVien, G.khoa, G.sdt, G.email FROM TAIKHOAN AS T"
                + " JOIN GIANGVIEN AS G ON T.id = G.idTaiKhoan"
                + " WHERE T.tenDangNhap = N'" + user + "' AND T.matKhau = N'" + pass + "'";

            return DataProvider.Khoitao.ExecuteQuery(query);
        }
        public DataTable GetGiangVienInfo_2(string user, string pass)
        {
            string query = "SELECT G.id, G.tenGiangVien, G.khoa, G.sdt, G.email FROM TAIKHOAN AS T"
                + " JOIN GIANGVIEN AS G ON T.id = G.idTaiKhoan"
                + " WHERE T.tenDangNhap = N'" + user + "' AND T.matKhau = N'" + pass + "'";

            return DataProvider.Khoitao.ExecuteQuery(query);
        }

    }
}


