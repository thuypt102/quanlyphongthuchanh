using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
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
        public DataTable loadTheoMa(string id)
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh from PHONGMAY where id = '" + id + "'");
        }
        public DataTable loadTheoLoai(string loaiThucHanh)
        {
            return DataProvider.Khoitao.ExecuteQuery("Select id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh from PHONGMAY where loaiThucHanh = N'" + loaiThucHanh + "'");
        }
        public DataTable loadTheoMaVaLoai(string idphong, string loaiPhong)
        {
            string query = "Select id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh from PHONGMAY  where id = '" + idphong + "'AND loaiThucHanh = N'" + loaiPhong + "'";
            return DataProvider.Khoitao.ExecuteQuery(query);
        }
        public bool themPhong(string id, string tenPhong, string tenKhuVuc, int soLuongMay, string loaiThucHanh)
        {
            bool luuTru = false;

            string query = "INSERT INTO PHONGMAY VALUES ('" + id + "', '" + tenPhong +
                "', '" + tenKhuVuc + "', '" + soLuongMay + "', N'" + loaiThucHanh + "', '" + luuTru + "')";

            DataTable kq = DataProvider.Khoitao.ExecuteQuery(query);

            return kq != null;
        }


        public bool capNhatPhong(string id, string tenPhong, string tenKhuVuc, int soLuongMay, string loaiThucHanh)
        {
            string query = "UPDATE PHONGMAY SET tenPhong = N'" + tenPhong + "', tenKhuVuc = N'" + tenKhuVuc +
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

        public bool kiemtraThongTinPhong(string id)
        {
            string query = "SELECT id FROM PHONGMAY WHERE id = '" + id + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public string KiemTraLoaiPhong(string loaiThucHanh, List<string> invalidIds, string id)
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

        public void taiDSlenCSDL(string id, string tenPhong, string tenKhuVuc, int soLuongMay, string loaiThucHanh)
        {
            string query = "INSERT INTO PHONGMAY(id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh)" +
                " VALUES ('" + id + "', N'" + tenPhong + "', '" + tenKhuVuc + "', '" + soLuongMay + "', N'" + loaiThucHanh + "')";

            DataProvider.Khoitao.ExecuteQuery(query);
        }
        public void taiLenPhong(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy trang tính đầu tiên

                int rowCount = worksheet.Dimension.Rows;
                int columnCount = worksheet.Dimension.Columns;

                // Kiểm tra xem số cột trong file Excel có khớp với cấu trúc bảng PHONGMAY hay không
                if (columnCount == 5)
                {
                    List<string> duplicateIds = new List<string>(); // Danh sách các ID bị trùng
                    List<string> invalidIds = new List<string>(); // Danh sách các ID không hợp lệ

                    // Bỏ qua dòng đầu tiên (tiêu đề)
                    for (int row = 2; row <= rowCount; row++)
                    {
                        string id = worksheet.Cells[row, 1].Value?.ToString();
                        string loaiThucHanh = worksheet.Cells[row, 5].Value?.ToString();

                        if (kiemtraThongTinPhong(id))
                        {
                            duplicateIds.Add(id);
                        }
                        else
                        {
                            string tenPhong = worksheet.Cells[row, 2].Value?.ToString();
                            string tenKhuVuc = worksheet.Cells[row, 3].Value?.ToString();
                            int soLuongMay = Convert.ToInt32(worksheet.Cells[row, 4].Value);

                            // Kiểm tra giá trị của loaiThucHanh và gán giá trị mặc định nếu không hợp lệ
                            loaiThucHanh = KiemTraLoaiPhong(loaiThucHanh, invalidIds, id);

                            taiDSlenCSDL(id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh);
                        }
                    }

                    if (duplicateIds.Count > 0)
                    {
                        string duplicateMessage = "Các ID bị trùng: " + string.Join(", ", duplicateIds);
                        MessageBox.Show(duplicateMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (invalidIds.Count > 0)
                    {
                        string invalidMessage = "Các ID phòng có loại phòng không hợp lệ là: " + string.Join(", ", invalidIds)
                            + "\nLoại phòng sẽ được đặt là \"Thực hành thông thường\"";
                        MessageBox.Show(invalidMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

