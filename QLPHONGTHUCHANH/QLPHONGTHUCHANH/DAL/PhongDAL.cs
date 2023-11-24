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

        public bool kiemtraThongTinPhong(string id)
        {
            string query = "SELECT id FROM PHONGMAY WHERE id = '" + id + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            return result.Rows.Count > 0;
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
                    List<int> duplicateRows = new List<int>(); // Danh sách các dòng bị trùng

                    // Bỏ qua dòng đầu tiên (tiêu đề)
                    for (int row = 2; row <= rowCount; row++)
                    {
                        string id = worksheet.Cells[row, 1].Value?.ToString();

                        // Kiểm tra xem id có bị trùng trong SQL hay không
                        if (kiemtraThongTinPhong(id))
                        {
                            duplicateRows.Add(row);
                        }
                        else
                        {
                            string tenPhong = worksheet.Cells[row, 2].Value?.ToString();
                            string tenKhuVuc = worksheet.Cells[row, 3].Value?.ToString();
                            int soLuongMay = Convert.ToInt32(worksheet.Cells[row, 4].Value);
                            string loaiThucHanh = worksheet.Cells[row, 5].Value?.ToString();

                            taiDSlenCSDL(id, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh);
                        }
                    }

                    if (duplicateRows.Count > 0)
                    {
                        string message = "Dữ liệu trùng lặp ở các dòng: ";
                        foreach (int row in duplicateRows)
                        {
                            message += row.ToString() + ", ";
                        }
                        message = message.TrimEnd(',', ' ');

                        // Hiển thị thông báo MessageBox
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

