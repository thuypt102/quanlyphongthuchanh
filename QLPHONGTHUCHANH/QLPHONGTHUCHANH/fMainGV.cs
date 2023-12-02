using OfficeOpenXml;
using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//using Excel = Microsoft.Office.Interop.Excel;

namespace QLPHONGTHUCHANH
{
    public partial class fMainGV : Form
    {
        public fMainGV()
        {
            InitializeComponent();
            loadNamHoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lbTieuDe.Hide();
            dtgLich.Show();
            string selectedValue = cmbLoai.SelectedItem.ToString();
            string tukhoa = txbTimKiem.Text;
            string nam = cmbNamHoc.Text.ToString();
            if (tukhoa == "" && selectedValue != "Tất cả")
            {
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nam == "Năm học")
            {
                if (selectedValue == "Tất cả")
                {
                    loadLich();
                }
                else
                {
                    //MessageBox.Show("Vui lòng chọn năm học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (selectedValue == "Lớp")
                    {
                        loadLichALLlop(tukhoa);
                    }
                    else if (selectedValue == "Giảng viên")
                    {
                        loadLichALLgv(tukhoa);
                    }
                    else if (selectedValue == "Phòng")
                    {
                        loadLichAllPhong(tukhoa);
                    }
                }
            }
            else if (selectedValue == "Lớp")
            {
                loadLichTheoLop(tukhoa, nam);
            }
            else if (selectedValue == "Giảng viên")
            {
                loadLichTheoGV(tukhoa, nam);
            }
            else if (selectedValue == "Phòng")
            {
                loadLichTheoPhong(tukhoa, nam);
            }
            else
            {
                loadLich();
            }
        }

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        void loadLich()
        {
            //dsTaiKhoan.DataSource = TaiKhoanBUS.Khoitao.layDStaikhoan();
            dtgLich.DataSource = LichDAL.Khoitao.getLichThucHanh();
        }
        void loadLichTheoLop(string lop, string nam)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichLop(lop, nam);
        }
        void loadLichTheoGV(string gv, string nam)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichGV(gv, nam);
        }
        void loadLichTheoPhong(string p, string nam)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichPhong(p, nam);
        }

        //load ALL
        void loadLichALLlop(string lop)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichLOPall(lop);
        }
        void loadLichALLgv(string gv)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichGVall(gv);
        }
        void loadLichAllPhong(string p)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichPHONGall(p);
        }

        void loadNamHoc()
        {
            // Lấy danh sách năm học từ cơ sở dữ liệu
            List<string> namHocList = LichDAL.Khoitao.loadNamHoc();

            // Thêm item mặc định vào danh sách năm học
            namHocList.Insert(0, "Năm học");

            // Gán danh sách năm học cho ComboBox
            cmbNamHoc.DataSource = namHocList;
        }

        private void btnXuatLich_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xuất lịch không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn vị trí lưu file Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Thiết lập LicenseContext trước khi sử dụng ExcelPackage
                    OfficeOpenXml.LicenseContext licenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelPackage.LicenseContext = licenseContext;

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Lịch");

                        // Lưu tiêu đề cột
                        for (int column = 0; column < dtgLich.Columns.Count; column++)
                        {
                            worksheet.Cells[1, column + 1].Value = dtgLich.Columns[column].HeaderText;
                        }

                        // Lưu dữ liệu từ DataGridView
                        for (int row = 0; row < dtgLich.Rows.Count; row++)
                        {
                            for (int column = 0; column < dtgLich.Columns.Count; column++)
                            {
                                worksheet.Cells[row + 2, column + 1].Value = dtgLich.Rows[row].Cells[column].Value;
                            }
                        }

                        // Lưu file Excel
                        byte[] excelData = excelPackage.GetAsByteArray();
                        File.WriteAllBytes(saveFileDialog.FileName, excelData);

                        MessageBox.Show("Lưu file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void mniQuanLy_Click(object sender, EventArgs e)
        {
            fGiangVien fgv = new fGiangVien();
            this.Hide();
            fgv.ShowDialog();
            this.Show();
        }

        private void mniThongTin_Click(object sender, EventArgs e)
        {
            fThongTinGiangVien ftvgv = new fThongTinGiangVien();
            this.Hide();
            ftvgv.ShowDialog();
            this.Show();
        }

        private void btnDoiPhong_Click(object sender, EventArgs e)
        {


            fDoiPhongMay fdpm = new fDoiPhongMay();
            this.Hide();
            fdpm.ShowDialog();
            this.Show();
        }
    }
}
