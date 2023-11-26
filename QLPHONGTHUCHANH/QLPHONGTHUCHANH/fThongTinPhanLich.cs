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
    public partial class fThongTinPhanLich : Form
    {
        public fThongTinPhanLich()
        {
            InitializeComponent();
            loadNamHoc();
        }

        void loadNamHoc()
        {
            List<string> nam = LichDAL.Khoitao.loadNamHoc().Select(l => l.NamHoc).ToList();

            if (nam.Count > 0)
            {
                string maxNamHoc = nam.Max(); // Lấy năm học có giá trị lớn nhất

                nam.Clear(); // Xóa tất cả các năm học hiện có

                // Tạo hai item mới từ năm học có giá trị lớn nhất
                int maxYear = int.Parse(maxNamHoc.Substring(0, 4));
                string namHoc1 = (maxYear + 1) + "-" + (maxYear + 2);
                string namHoc2 = (maxYear + 2) + "-" + (maxYear + 3);

                nam.Add(maxNamHoc);
                nam.Add(namHoc1);
                nam.Add(namHoc2);
            }

            cmbNamHoc.DataSource = nam;
        }
    }
}
