using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DAL
{
    public class ThongBaoDAL
    {
        private static ThongBaoDAL khoitao;
        public static ThongBaoDAL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new ThongBaoDAL();
                return ThongBaoDAL.khoitao;
            }
            private set { ThongBaoDAL.khoitao = value; }
        }

        private ThongBaoDAL() { }
        /*public List<ThongBao> hienThiTB()
        {
            List<ThongBao> listTB = new List<ThongBao>();

            string query = "Select * from THONGBAO";
            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow row in kq.Rows)
            {

                string id = row["id"].ToString();
                string tieude = row["tieuDe"].ToString();
                string noidung = row["noiDung"].ToString();
                string idGV = row["idGiangVien"].ToString();
                string thoigiangui = row["thoiGianGui"].ToString();
                bool? trangthai = row["trangThai"].ToString() == string.Empty ? null : (bool?)row["trangThai"];

                ThongBao TB = new ThongBao(id, tieude, noidung, idGV, thoigiangui, trangthai);
                listTB.Add(TB);
            }

            return listTB;
        }*/

        public DataTable hienThiThongBao()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id,tieuDe,noiDung,idGiangVien,thoiGianGui from THONGBAO ");
        }
        public DataTable hienThiThongBao_daxuly()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id,tieuDe,noiDung,idGiangVien,thoiGianGui from THONGBAO where trangThai = 1");
        }
        public DataTable hienThiThongBao_chuaxuly()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id,tieuDe,noiDung,idGiangVien,thoiGianGui from THONGBAO where trangThai = 0");
        }

    }
}
