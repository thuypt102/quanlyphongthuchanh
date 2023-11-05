using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DAL
{
    public class LichDAL
    {
        private static LichDAL khoitao;

        public static LichDAL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new LichDAL();
                return LichDAL.khoitao;
            }
            private set { LichDAL.khoitao = value; }
        }

        private LichDAL() { }

        public DataTable getLichThucHanh()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select * from LICHTHUCHANH");
        }

        public DataTable getLichLop(string lop, string nam)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idLop = '" + lop + "' AND namHoc = '" + nam + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN LOP ON LICHTHUCHANH.idLop = LOP.id WHERE LOP.tenLop = N'" + lop + "' AND LICHTHUCHANH.namHoc = '" + nam + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }

            return result;
        }
        public DataTable getLichGV(string gv, string nam)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idGiangVien = '" + gv + "' AND namHoc = '" + nam + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN GIANGVIEN ON LICHTHUCHANH.idGiangVien = GIANGVIEN.id WHERE GIANGVIEN.tenGiangVien = N'" + gv + "' AND LICHTHUCHANH.namHoc = '" + nam + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }

            return result;
        }
        public DataTable getLichPhong(string phong, string nam)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idPhong = '" + phong + "' AND namHoc = '" + nam + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN PHONGMAY ON LICHTHUCHANH.idPhong = PHONGMAY.id WHERE PHONGMAY.tenPhong = N'" + phong + "' AND LICHTHUCHANH.namHoc = '" + nam + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }

            return result;
        }
        public List<string> loadNamHoc2()
        {
            List<string> uniqueNamHoc = new List<string>();
            string query = "SELECT DISTINCT namHoc FROM LICHTHUCHANH";
            DataTable dta = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow item in dta.Rows)
            {
                string namHoc = item["namHoc"].ToString();
                uniqueNamHoc.Add(namHoc);
            }
            return uniqueNamHoc;
        }

        public List<Lich> loadNamHoc()
        {
            List<Lich> list = new List<Lich>();
            string query = "SELECT * FROM LICHTHUCHANH WHERE namHoc IN (SELECT DISTINCT namHoc FROM LICHTHUCHANH)";
            DataTable dta = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow item in dta.Rows)
            {
                Lich nam = new Lich(item);
                list.Add(nam);
            }
            return list;
        }
    }
}
