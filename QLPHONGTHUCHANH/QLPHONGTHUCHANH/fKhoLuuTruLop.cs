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
        }

        public void loadDSLop()
        {
            dtaLop.DataSource = LopDAL.Khoitao.getDSLop();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn khôi phục lớp?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i;
                i = dtaLop.CurrentRow.Index;

                string maL = dtaLop.Rows[i].Cells[0].Value.ToString();
                if (LopDAL.Khoitao.khoiPhucLop(maL))
                {
                    MessageBox.Show("Khôi phục phòng thành công!", "Thông báo");
                    loadDSLop();
                }
                else
                {
                    MessageBox.Show("Khôi phục phòng không thành công!", "Thông báo");
                }
            }
        }
    }
}
