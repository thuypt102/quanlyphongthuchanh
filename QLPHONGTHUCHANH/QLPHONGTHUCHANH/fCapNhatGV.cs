﻿using QLPHONGTHUCHANH.DAL;
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

namespace QLPHONGTHUCHANH
{
    public partial class fCapNhatGV : Form
    {
        public fCapNhatGV(GV  gv)
        {
            InitializeComponent();
            hienThi(gv);
        }


        private void hienThi(GV gv)
        {
            txbMaGV.Text = gv.Id;
            txbTenGV.Text = gv.TenGiangVien;
            txbKhoa.Text = gv.Khoa;
            txbSDT.Text = gv.Sdt;
            txbIDTaiKhoan.Text = gv.IdTaiKhoan.ToString();
            
        }

        private bool IsValidInput()
        {
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbIDTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào TextBox.", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không
            if (!int.TryParse(txbIDTaiKhoan.Text, out int result))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }

            // Giá trị nhập vào hợp lệ
            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {

                string magv = txbMaGV.Text;
                string tengv = txbTenGV.Text;
                string tenKhoa = txbKhoa.Text;
                string sdt = txbSDT.Text;
                int idtaikhoan = int.Parse(txbIDTaiKhoan.Text);

                if (GVDALL.Khoitao.capNhatGV(magv, tengv, tenKhoa, sdt, idtaikhoan))
                {
                    MessageBox.Show("cập nhật thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("cập nhật không thành công!", "Thông báo");
            }
        }

        
    }
}
