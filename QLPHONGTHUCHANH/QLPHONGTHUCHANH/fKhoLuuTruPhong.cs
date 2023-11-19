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
    public partial class fKhoLuuTruPhong : Form
    {
        public fKhoLuuTruPhong()
        {
            InitializeComponent();
            loadDSPhong();
            showKhoiPhuc();
        }

        public void loadDSPhong()
        {
            dtaPhongMay.DataSource = PhongDAL.Khoitao.getDSPhong();
        }

        public void showKhoiPhuc()
        {
            if (dtaPhongMay.Rows.Count == 1)
            {
                btnKhoiPhuc.Enabled = false;
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn khôi phục phòng?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i;
                i = dtaPhongMay.CurrentRow.Index;

                string maP = dtaPhongMay.Rows[i].Cells[0].Value.ToString();
                if (PhongDAL.Khoitao.khoiPhucPhong(maP))
                {
                    MessageBox.Show("Khôi phục phòng thành công!", "Thông báo");
                    loadDSPhong();
                    showKhoiPhuc();
                }
                else
                {
                    MessageBox.Show("Khôi phục phòng không thành công!", "Thông báo");
                }
            }
        }
    }
}
