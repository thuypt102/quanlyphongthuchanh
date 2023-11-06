using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Excel = Microsoft.Office.Interop.Excel;

namespace QLPHONGTHUCHANH
{
    public partial class fMain : Form
    {
        public fMain()
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
            else
            {
                if (selectedValue == "Lớp")
                {
                    loadLichTheoLop(tukhoa, nam);
                }
                else if (selectedValue == "Giảng viên")
                {
                    loadLichTheoGV(tukhoa, nam);
                }
                else if(selectedValue == "Phòng")
                {
                    loadLichTheoPhong(tukhoa, nam);
                }    
                else
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
        void loadNamHoc()
        {
            List<Lich> nam = LichDAL.Khoitao.loadNamHoc();
            cmbNamHoc.DataSource = nam;
            cmbNamHoc.DisplayMember = "namHoc";
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
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.ActiveSheet;

                    // Lưu tiêu đề cột
                    for (int column = 0; column < dtgLich.Columns.Count; column++)
                    {
                        worksheet.Cells[1, column + 1] = dtgLich.Columns[column].HeaderText;
                    }

                    // Lưu dữ liệu từ DataGridView
                    for (int row = 0; row < dtgLich.Rows.Count; row++)
                    {
                        for (int column = 0; column < dtgLich.Columns.Count; column++)
                        {
                            worksheet.Cells[row + 2, column + 1] = dtgLich.Rows[row].Cells[column].Value;
                        }
                    }

                    // Lưu file Excel
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Lưu file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void mniQuanLy_Click(object sender, EventArgs e)
        {
            fQuanLy fql = new fQuanLy();
            //fql.taikhoannow = Taikhoandn;
            this.Hide();
            fql.ShowDialog();
            this.Show();
        }

        
    }
}
