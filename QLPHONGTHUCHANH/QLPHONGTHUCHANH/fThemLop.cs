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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLPHONGTHUCHANH
{
    public partial class fThemLop : Form
    {
        public fThemLop()
        {
            InitializeComponent();
        }

        private bool IsValidInput()
        {
            // id giảng viên
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbIDGV.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào .", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không
            /*if (!int.TryParse(txbIDGV.Text, out int IDGV))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }*/
            //ca lý thuyết
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbCaLT.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào .", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không
            if (!int.TryParse(txbCaLT.Text, out int result))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }
            //số lượng sinh viên
            if (string.IsNullOrWhiteSpace(txbSlSV.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào .", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không
            if (!int.TryParse(txbSlSV.Text, out int SlSV))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }
            // Giá trị nhập vào hợp lệ
            return true;
        }

        private void vbThemLop_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                string maLop = txbMaLop.Text;
                string tenLop = txbTenLop.Text;
                string tenKhoa = txbKhoa.Text;
                string IDGV = txbIDGV.Text;
                string caLT = txbCaLT.Text;
                int SLSV = int.Parse(txbSlSV.Text);
                string Loai = cmbLoai.Text;
                if (Loai == "")
                {
                    Loai = "Thực hành thông thường";
                }
                if (LopDAL.Khoitao.timKiem(maLop))
                {
                    MessageBox.Show("Mã lớp đã tồn tại. Vui lòng nhập mã khác.");

                }
                else
                {
                    if (!GVDALL.Khoitao.timKiem(IDGV))
                    {
                        MessageBox.Show("Mã giảng viên không tồn tại. Vui lòng nhập mã khác.");

                    }

                    else
                    {

                        if (LopDAL.Khoitao.themLop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai))
                        {
                            MessageBox.Show("thêm thành công!", "Thông báo");
                        }
                        else
                            MessageBox.Show("thêm không thành công!", "Thông báo");
                    }
                }
            }
        }
        
    }
}
