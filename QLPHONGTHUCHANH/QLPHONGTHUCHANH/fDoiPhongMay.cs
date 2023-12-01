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
    public partial class fDoiPhongMay : Form
    {
        public fDoiPhongMay()
        {
            InitializeComponent();
            loadLich();
        }
        void loadLich()
        {
            //dsTaiKhoan.DataSource = TaiKhoanBUS.Khoitao.layDStaikhoan();
            dtaDoiPM.DataSource = LichDAL.Khoitao.getLichThucHanh();
        }
        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtaDoiPM.CurrentRow == null)
            {
                MessageBox.Show("Không có lịch nào trong danh sách", "Thông báo");
                return;
            }

            int i = dtaDoiPM.CurrentRow.Index;

            int id = int.Parse(dtaDoiPM.Rows[i].Cells[0].Value.ToString());
            int idCaThucHanh = int.Parse(dtaDoiPM.Rows[i].Cells[1].Value.ToString());
            string idLop = dtaDoiPM.Rows[i].Cells[2].Value.ToString();
            string idPhong = dtaDoiPM.Rows[i].Cells[3].Value.ToString();
            string idGiangVien = dtaDoiPM.Rows[i].Cells[4].Value.ToString();
            string namHoc = dtaDoiPM.Rows[i].Cells[5].Value.ToString();
            int kiHoc = int.Parse(dtaDoiPM.Rows[i].Cells[6].Value.ToString());
            string thu = dtaDoiPM.Rows[i].Cells[7].Value.ToString();

            Lich lich = new Lich(id, idCaThucHanh,  idLop,  idPhong,  idGiangVien,  namHoc,  kiHoc,  thu);


            fCapNhatLich fcnl = new fCapNhatLich(lich);
            this.Hide();
            fcnl.ShowDialog();
            this.Show();
            loadLich();
        }
    }
}
