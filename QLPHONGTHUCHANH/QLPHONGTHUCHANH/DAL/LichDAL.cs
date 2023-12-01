using Microsoft.Office.Interop.Excel;
using Microsoft.SqlServer.Server;
using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public System.Data.DataTable getLichThucHanh()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select * from LICHTHUCHANH");
        }

        public bool ThemLich(int idCaThucHanh, string idLop, string idPhong, string idGiangVien, string namHoc, int kiHoc, string thu)
        {
            string query = "INSERT INTO LICHTHUCHANH (idCaThucHanh, idLop, idPhong, idGiangVien, namHoc, kiHoc, thu) VALUES (" + idCaThucHanh + ", '" + idLop + "', '" + idPhong + "', '" + idGiangVien + "', '" + namHoc + "', " + kiHoc + ", '" + thu + "')";
            System.Data.DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }

        public bool CapNhatPhong(int idlich, string idPhongMoi)
        {
            string query = "UPDATE LICHTHUCHANH SET idPhong = '" + idPhongMoi + "' WHERE id = " + idlich;
            System.Data.DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }

        public bool ThemLich2(int idCaThucHanh, string idLop, string idPhong, string idGiangVien, string namHoc, int kiHoc, int thu)
        {
            string query = "INSERT INTO LICHTHUCHANH (idCaThucHanh, idLop, idPhong, idGiangVien, namHoc, kiHoc, thu) " +
                "VALUES (" + idCaThucHanh + ", '" + idLop + "', '" + idPhong + "', '" + idGiangVien + "', '" + namHoc + "', " + kiHoc + ", " + thu + ")";
            System.Data.DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }
        
        public bool KiemTraIdPhongTrong(int cath ,string idPhong ,/*string lop,*/ string nam,int kiHoc , string thu )
        {
            string query = "SELECT id FROM LICHTHUCHANH WHERE idCaThucHanh = '"+cath+"' AND idPhong= '" + idPhong+ /*"' AND idLop = '"+ lop +*/ "' AND namHoc = '" + nam  + "' AND kiHoc =" + kiHoc + "  AND thu = '"+ thu + "'";
            System.Data.DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            if (result.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }
        public System.Data.DataTable getLichLop(string lop, string nam)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idLop = '" + lop + "' AND namHoc = '" + nam + "'";
            System.Data.DataTable result = DataProvider.Khoitao.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN LOP ON LICHTHUCHANH.idLop = LOP.id WHERE LOP.tenLop = N'" + lop + "' AND LICHTHUCHANH.namHoc = '" + nam + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }

            return result;
        }
        public System.Data.DataTable getLichGV(string gv, string nam)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idGiangVien = '" + gv + "' AND namHoc = '" + nam + "'";
            System.Data.DataTable result = DataProvider.Khoitao.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN GIANGVIEN ON LICHTHUCHANH.idGiangVien = GIANGVIEN.id WHERE GIANGVIEN.tenGiangVien = N'" + gv + "' AND LICHTHUCHANH.namHoc = '" + nam + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }

            return result;
        }
        public System.Data.DataTable getLichPhong(string phong, string nam)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idPhong = '" + phong + "' AND namHoc = '" + nam + "'";
            System.Data.DataTable result = DataProvider.Khoitao.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN PHONGMAY ON LICHTHUCHANH.idPhong = PHONGMAY.id WHERE PHONGMAY.tenPhong = N'" + phong + "' AND LICHTHUCHANH.namHoc = '" + nam + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }

            return result;
        }

        public System.Data.DataTable getLichNam(string nam)
        {
            return DataProvider.Khoitao.ExecuteQuery("Select * from LICHTHUCHANH where namHoc = '" + nam + "'");
        }

        public System.Data.DataTable getLichGVall(string gv)
        {
            string query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN GIANGVIEN ON LICHTHUCHANH.idGiangVien = GIANGVIEN.id WHERE GIANGVIEN.id = N'" + gv + "'";
            System.Data.DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN GIANGVIEN ON LICHTHUCHANH.idGiangVien = GIANGVIEN.id WHERE GIANGVIEN.tenGiangVien = N'" + gv + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }
            return result;
        }

        public System.Data.DataTable getLichLOPall(string lop)
        {
            string query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN LOP ON LICHTHUCHANH.idLop = LOP.id WHERE LOP.id = N'" + lop + "'";
            System.Data.DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            if (result.Rows.Count == 0)
            {
                query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN LOP ON LICHTHUCHANH.idLop = LOP.id WHERE LOP.tenLop = N'" + lop + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }
            return result;
        }

        public System.Data.DataTable getLichPHONGall(string phong)
        {
            string query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN PHONGMAY ON LICHTHUCHANH.idPhong = PHONGMAY.id WHERE PHONGMAY.id = N'" + phong + "'";
            System.Data.DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            if (result.Rows.Count == 0)
            {
                query = query = "SELECT LICHTHUCHANH.* FROM LICHTHUCHANH JOIN PHONGMAY ON LICHTHUCHANH.idPhong = PHONGMAY.id WHERE PHONGMAY.tenPhong = N'" + phong + "'";
                result = DataProvider.Khoitao.ExecuteQuery(query);
            }
            return result;
        }

        public List<string> loadNamHoc2()
        {
            List<string> uniqueNamHoc = new List<string>();
            string query = "SELECT DISTINCT namHoc FROM LICHTHUCHANH";
            System.Data.DataTable dta = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow item in dta.Rows)
            {
                string namHoc = item["namHoc"].ToString();
                uniqueNamHoc.Add(namHoc);
            }
            return uniqueNamHoc;
        }

        public List<string> loadNamHoc()
        {
            List<string> list = new List<string>();
            string query = "SELECT DISTINCT namHoc FROM LICHTHUCHANH";
            System.Data.DataTable dataTable = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                string namHoc = row["namHoc"].ToString();
                list.Add(namHoc);
            }

            return list;
        }
        public List<Lich> loadkiHoc(string nam)
        {
            List<Lich> list = new List<Lich>();
            //string query = "SELECT * FROM LICHTHUCHANH WHERE kiHoc IN (SELECT DISTINCT kiHoc FROM LICHTHUCHANH)";
            string query = "SELECT* FROM LICHTHUCHANH WHERE kiHoc = ( " +
                "SELECT MAX(kiHoc) FROM LICHTHUCHANH WHERE namHoc = '"+nam+"') AND namHoc = '"+nam+"'";
            System.Data.DataTable dta = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow item in dta.Rows)
            {
                Lich ki = new Lich(item);
                list.Add(ki);
            }
            return list;
        }

        public List<string> GetPhongChuaCoTrongLichTH(int caThucHanh, string lop, string giangVien, int kiHoc, string thu)
        {
            List<string> danhSachPhong = new List<string>();
            string query = $"SELECT DISTINCT id FROM PHONGMAY WHERE id NOT IN (SELECT DISTINCT idPhong FROM LICHTHUCHANH WHERE idCaThucHanh = {caThucHanh} AND idLop = '{lop}' AND idGiangVien = '{giangVien}' AND kiHoc = {kiHoc} AND thu = '{thu}')";
            System.Data.DataTable dataTable = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                string phongRow = row["id"].ToString();
                danhSachPhong.Add(phongRow);
            }

            return danhSachPhong;
        }

        public bool KiemTraPhongTrong(string idPhong, int caThucHanh, int thu, string namHoc, int kiHoc)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idPhong = '" + idPhong + "' AND idCaThucHanh = " + caThucHanh + " AND thu = " + thu + " AND namHoc = '" + namHoc + "' AND kiHoc = " + kiHoc;
            System.Data.DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq.Rows.Count == 0; // Trả về true nếu không có lịch thực hành tương ứng, ngược lại trả về false
        }

        public bool KiemTraLopBan(int caThucHanh, int thu, string namHoc, int kiHoc)
        {
            string query = "SELECT * FROM LICHTHUCHANH WHERE idCaThucHanh = " + caThucHanh + " AND thu = " + thu + " AND namHoc = '" + namHoc + "' AND kiHoc = " + kiHoc;
            System.Data.DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq.Rows.Count == 0; // Trả về true nếu lớp kh bận
        }
    }
}
