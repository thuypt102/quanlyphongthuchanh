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
            List<string> nam = LichDAL.Khoitao.loadNamHoc();

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

        private void btnPhanLich_Click(object sender, EventArgs e)
        {
            string namHoc = cmbNamHoc.SelectedItem.ToString();
            int kiHoc = Convert.ToInt32(cmbKiHoc.SelectedItem);
            int thu = 2;
            int ca = 1;

            DataTable danhSachLop = LopDAL.Khoitao.getDSLop0();
            DataTable danhSachPhong = PhongDAL.Khoitao.getDSPhong0();
            int soCa = CaDAL.Khoitao.demSoCa();
            
            try
            {
                // Duyệt qua từng lớp để phân lịch
                foreach (DataRow l in danhSachLop.Rows)
                {
                    
                    //lấy thông tin của ca lý thuyết
                    int lyThuyet = Convert.ToInt32(l["caLyThuyet"]);

                    int thuLT = lyThuyet / 10; // Lấy chữ số hàng chục (x)
                    int caLT = lyThuyet % 10; // Lấy chữ số hàng đơn vị (y)

                    int siso = Convert.ToInt32(l["soLuongSinhVien"]);
                    int soNhom = LopDAL.Khoitao.GetSoNhomThucHanh(siso);

                    string loaiLop = l["loaiThucHanh"].ToString();

                    while (soNhom > 0)
                    {
   
                        // Lấy thông tin cần thiết để phân lịch
                        string idLop = l["id"].ToString();
                        string idGiangVien = l["idGiangVienPhuTrach"].ToString();

                        foreach (DataRow p in danhSachPhong.Rows)
                        {
                            string idPhong = p["id"].ToString();

                            bool ktTrong = LichDAL.Khoitao.KiemTraPhongTrong(idPhong, ca, thu, namHoc, kiHoc);
                            bool ktLopBan = LichDAL.Khoitao.KiemTraLopBan(ca, thu, namHoc, kiHoc);

                            string loaiPhong = l["loaiThucHanh"].ToString();

                            if (ktLopBan)
                            {
                                if (ktTrong && (loaiPhong.Equals(loaiLop, StringComparison.Ordinal)))
                                {
                                    if (thu != thuLT && ca != caLT)
                                    {
                                        // Gọi hàm ThemLich để lưu phân lịch
                                        LichDAL.Khoitao.ThemLich2(ca, idLop, idPhong, idGiangVien, namHoc, kiHoc, thu);
                                        break;
                                    }
                                }
                            }    
                        }
                        soNhom--;
                        ca++;
                    }
                    if (ca == soCa)
                    {
                        ca = 1;
                        thu++;
                    }
                    if (ca == soCa && thu == 8)
                    {
                        MessageBox.Show("Đã hết phòng!", "Thông báo");
                        //dừng tất cả
                        break;
                    }
                }

                // Phân lịch thành công
                MessageBox.Show("Phân lịch thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi trong quá trình phân lịch: " + ex.Message);
            }
        }
    }
}
