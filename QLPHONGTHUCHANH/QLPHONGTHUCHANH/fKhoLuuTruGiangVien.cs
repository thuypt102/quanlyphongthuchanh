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

namespace QLPHONGTHUCHANH
{
    public partial class fKhoLuuTruGiangVien : Form
    {
        public fKhoLuuTruGiangVien()
        {
            InitializeComponent();
            loadDSgv();
            showKhoiPhuc();
        }

        public void loadDSgv()
        {
            dtaGiangVien.DataSource = GVDALL.Khoitao.getDSgv();
        }

        public void showKhoiPhuc()
        {
            if (dtaGiangVien.Rows.Count == 1)
            {
                btnKhoiPhuc.Enabled = false;
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn khôi phục thông tin giảng viên?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i;
                i = dtaGiangVien.CurrentRow.Index;

                string maGV = dtaGiangVien.Rows[i].Cells[0].Value.ToString();
                if (GVDALL.Khoitao.khoiPhucGiangVien(maGV))
                {
                    MessageBox.Show("Khôi phục giảng viên thành công!", "Thông báo");
                    loadDSgv();
                    showKhoiPhuc();
                }
                else
                {
                    MessageBox.Show("Khôi phục giảng viên không thành công!", "Thông báo");
                }
            }
        }
    }
}
