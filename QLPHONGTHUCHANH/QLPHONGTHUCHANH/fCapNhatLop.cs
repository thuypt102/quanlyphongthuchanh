using QLPHONGTHUCHANH.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPHONGTHUCHANH.DTO;

namespace QLPHONGTHUCHANH
{
    public partial class fCapNhatLop : Form
    {
        public fCapNhatLop(Lop lop)
        {
            InitializeComponent();
            hienThi(lop);
        }

        private void hienThi(Lop lop)
        {
            txbMaLop.Text = lop.Id;
            txbTenLop.Text = lop.TenLop;
            txbKhoa.Text = lop.TenKhoa;
            txbIDGV.Text = lop.IdGiangVienPhuTrach;
            txbCaLT.Text = lop.CaLyThuyet;
            txbSlSV.Text = lop.SoLuongSinhVien.ToString();
            cmbLoai.Text = lop.LoaiThucHanh.ToString();
        }
       

        private void vbButton1_Click(object sender, EventArgs e)
        {
            string maLop = txbMaLop.Text;
            string tenLop = txbTenLop.Text;
            string tenKhoa = txbKhoa.Text;
            string IDGV = txbIDGV.Text;
            string caLT = txbCaLT.Text;
            int SLSV = int.Parse(txbSlSV.Text);
            int Loai = int.Parse(cmbLoai.SelectedItem.ToString());

            if (LopDAL.Khoitao.capNhatLop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai))
            {
                MessageBox.Show("cập nhật thành công!", "Thông báo");
            }
            else
                MessageBox.Show("cập nhật không thành công!", "Thông báo");
        }
    }
}
