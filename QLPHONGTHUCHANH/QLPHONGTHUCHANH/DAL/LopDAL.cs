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

        public string GetIdLop(string tenLop)
        {
            string query = "SELECT * FROM LOP WHERE tenLop = '" + tenLop + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                string idLop = result.Rows[0]["id"].ToString();
                return idLop;
            }
            else
            {
                return null;
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

        public bool kiemtraIDLop(string id)
        {
            string query = "SELECT id FROM LOP WHERE id = '" + id + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public string KiemTraLoaiThucHanh(string loaiThucHanh, List<string> invalidIds, string id)
        {
            if (string.IsNullOrEmpty(loaiThucHanh) ||
                (loaiThucHanh != "Thực hành thông thường" &&
                 loaiThucHanh != "Thực hành lắp ráp" &&
                 loaiThucHanh != "Thực hành mạng"))
            {
                loaiThucHanh = "Thực hành thông thường";
                invalidIds.Add(id);
            }

            return loaiThucHanh;
        }

        public void taiDSlenCSDL(string id, string tenLop, string tenKhoa, string idGiangVienPhuTrach, string caLyThuyet, int soLuongSV, string loai)
        {
            string query = "INSERT INTO LOP(id, tenLop, tenKhoa, idGiangVienPhuTrach, caLyThuyet, soLuongSinhVien, loaiThucHanh)" +
                " VALUES ('" + id + "', N'" + tenLop + "', N'" + tenKhoa + "', '" + idGiangVienPhuTrach + "', '" + caLyThuyet + "', '" + soLuongSV + "', N'" + loai + "')";

            DataProvider.Khoitao.ExecuteQuery(query);
        }

        public bool kiemTraIDGiangVien(string id)
        {
            string query = "SELECT id FROM GIANGVIEN WHERE id = '" + id + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool kiemTraIDCa(char id)
        {
            string query = "SELECT id FROM CATHUCHANH WHERE id = '" + id + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool KiemTraCaThucHanh(string caThucHanh)
        {
            if (caThucHanh.Length != 2)
            {
                return false;
            }

            char chuc = caThucHanh[0];
            if (chuc < '2' || chuc > '7')
            {
                return false;
            }

            char donVi = caThucHanh[1];

            if(kiemTraIDCa(donVi)==false)
            {
                return false;
            }    

            return true;
        }

        public void taiLenLop(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                List<string> duplicateIds = new List<string>(); // Danh sách các ID bị trùng
                List<string> invalidIds = new List<string>(); // Danh sách các ID không hợp lệ
                List<string> invalidGvIds = new List<string>(); // Danh sách các ID lớp có ID giảng viên không hợp lệ
                List<string> invalidCaThucHanhIds = new List<string>(); // Danh sách các ID lớp có caThucHanh không hợp lệ

                foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                {
                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;

                    // Kiểm tra xem số cột trong sheet có khớp với cấu trúc bảng LOP hay không
                    if (columnCount == 7)
                    {
                        // Bỏ qua dòng đầu tiên (tiêu đề)
                        for (int row = 2; row <= rowCount; row++)
                        {
                            string id = worksheet.Cells[row, 1].Value?.ToString();
                            string loaiThucHanh = worksheet.Cells[row, 7].Value?.ToString();
                            string caThucHanh = worksheet.Cells[row, 5].Value?.ToString();

                            if (kiemtraIDLop(id))
                            {
                                duplicateIds.Add(id);
                            }
                            else
                            {
                                string tenLop = worksheet.Cells[row, 2].Value?.ToString();
                                string tenKhoa = worksheet.Cells[row, 3].Value?.ToString();
                                string idGiangVienPhuTrach = worksheet.Cells[row, 4].Value.ToString();
                                int soLuongSV = Convert.ToInt32(worksheet.Cells[row, 6].Value);

                                // Kiểm tra giá trị của loaiThucHanh và gán giá trị mặc định nếu không hợp lệ
                                loaiThucHanh = KiemTraLoaiThucHanh(loaiThucHanh, invalidIds, id);

                                // Kiểm tra giá trị của caThucHanh
                                bool isValidCaThucHanh = KiemTraCaThucHanh(caThucHanh);
                                if (isValidCaThucHanh)
                                {
                                    // Kiểm tra xem ID giảng viên có hợp lệ hay không
                                    if (kiemTraIDGiangVien(idGiangVienPhuTrach))
                                    {
                                        taiDSlenCSDL(id, tenLop, tenKhoa, idGiangVienPhuTrach, caThucHanh, soLuongSV, loaiThucHanh);
                                    }
                                    else
                                    {
                                        invalidGvIds.Add(id);
                                    }
                                }
                                else
                                {
                                    invalidCaThucHanhIds.Add(id);
                                }
                            }
                        }
                    }
                }

                if (duplicateIds.Count > 0)
                {
                    string duplicateMessage = "Các ID bị trùng: " + string.Join(", ", duplicateIds);
                    MessageBox.Show(duplicateMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (invalidIds.Count > 0)
                {
                    string invalidMessage = "Các ID lớp có loại thực hành không hợp lệ là: " + string.Join(", ", invalidIds)
                        + "\nLoại thực hành các lớp này sẽ được đặt là \"Thực hành thông thường\"";
                    MessageBox.Show(invalidMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (invalidGvIds.Count > 0)
                {
                    string invalidGvMessage = "Các ID lớp có ID giảng viên không hợp lệ là: " + string.Join(", ", invalidGvIds);
                    MessageBox.Show(invalidGvMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (invalidCaThucHanhIds.Count > 0)
                {
                    string invalidCaThucHanhMessage = "Các ID lớp có caThucHanh không hợp lệ là: " + string.Join(", ", invalidCaThucHanhIds);
                    MessageBox.Show(invalidCaThucHanhMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
