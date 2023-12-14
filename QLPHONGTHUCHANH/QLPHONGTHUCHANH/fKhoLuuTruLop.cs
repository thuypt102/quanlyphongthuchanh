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
    public partial class fKhoLuuTruLop : Form
    {
        public fKhoLuuTruLop()
        {
            InitializeComponent();
            loadDSLop();
            showKhoiPhuc();
        }

        public void loadDSLop()
        {
            dtaLop.DataSource = LopDAL.Khoitao.getDSLop();
        }

        public void showKhoiPhuc()
        {
            if (dtaLop.Rows.Count == 1)
            {
                btnKhoiPhuc.Enabled = false;
            }
        }
        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn khôi phục thông tin lớp này không?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i;
                i = dtaLop.CurrentRow.Index;

                string maL = dtaLop.Rows[i].Cells[0].Value.ToString();

                if (LopDAL.Khoitao.khoiPhucLop(maL))
                {
                    MessageBox.Show("Đã khôi phục thông tin lớp!", "Thông báo");
                    loadDSLop();
                    showKhoiPhuc();
                }
                else
                {
                    MessageBox.Show("Khôi phục lớp không thành công!", "Thông báo");
                }
            }
        }
    }
}
