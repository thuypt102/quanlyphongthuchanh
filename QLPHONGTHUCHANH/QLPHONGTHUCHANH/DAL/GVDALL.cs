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
using OfficeOpenXml;
using System.IO;

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

        public bool xoaTK(string id)
        {           
            string query = "DELETE FROM TAIKHOAN WHERE id = (SELECT idTaiKhoan FROM GIANGVIEN WHERE id = " + id;
            int numberOfRowsDeleted = DataProvider.Khoitao.ExecuteNonQuery(query);

            return numberOfRowsDeleted > 0;
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
            string query = string.Format("UPDATE GIANGVIEN SET luuTru = 0 WHERE id =  '" + id + "'");
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool luuTruGiangVien(string id)
        {
            string query = string.Format("UPDATE GIANGVIEN SET luuTru = 1 WHERE id =  '" + id + "'");
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool kiemtraThongTinGV(string id)
        {
            string query = "SELECT id FROM GIANGVIEN WHERE id = '" + id + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public void taiDSlenCSDL(string id, string tenGV, string khoa, string sdt, string email)
        {
            string query = "INSERT INTO GIANGVIEN(id, tenGiangVien, khoa, sdt, email)" +
                " VALUES ('" + id + "', N'" + tenGV + "', N'" + khoa + "', '" + sdt + "', N'" + email + "')";

            DataProvider.Khoitao.ExecuteQuery(query);
        }

        public void capNhatIdTaiKhoan(string idGiangVien, int idTaiKhoan)
        {
            string query = "UPDATE GIANGVIEN SET idTaiKhoan = " + idTaiKhoan + " WHERE id = '" + idGiangVien + "'";
            DataProvider.Khoitao.ExecuteNonQuery(query);
        }
        /*public void capNhatIdTaiKhoan(string idGiangVien)
        {
            // Lấy id tài khoản mới được thêm vào
            string queryGetNewId = "SELECT MAX(id) FROM TAIKHOAN";
            int idTaiKhoanMoi = Convert.ToInt32(DataProvider.Khoitao.ExecuteScalar(queryGetNewId));

            // Cập nhật idTaiKhoan cho giảng viên trong bảng dbo.GIANGVIEN
            string queryUpdate = "UPDATE GIANGVIEN SET idTaiKhoan = " + idTaiKhoanMoi + " WHERE id = '" + idGiangVien + "'";
            DataProvider.Khoitao.ExecuteNonQuery(queryUpdate);
        }*/

        public void taiLenGV(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                List<string> duplicateIds = new List<string>(); // Danh sách các ID bị trùng

                foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                {
                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;

                    // Kiểm tra xem số cột trong sheet có khớp với cấu trúc bảng GIANGVIEN hay không
                    if (columnCount == 5)
                    {
                        // Bỏ qua dòng đầu tiên (tiêu đề)
                        for (int row = 2; row <= rowCount; row++)
                        {
                            string id = worksheet.Cells[row, 1].Value?.ToString();

                            if (kiemtraThongTinGV(id))
                            {
                                duplicateIds.Add(id);
                            }
                            else
                            {
                                string tenGiangVien = worksheet.Cells[row, 2].Value?.ToString();
                                string khoa = worksheet.Cells[row, 3].Value?.ToString();
                                string sdt = worksheet.Cells[row, 4].Value.ToString();
                                string email = worksheet.Cells[row, 5].Value?.ToString();

                                taiDSlenCSDL(id, tenGiangVien, khoa, sdt, email);
                            }
                        }
                    }
                }

                if (duplicateIds.Count > 0)
                {
                    string duplicateMessage = "Các ID bị trùng: " + string.Join(", ", duplicateIds);
                    MessageBox.Show(duplicateMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
