using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DAL
{
    public class CaThucHanh
    {
        private int id;
        private string tenCaThucHanh;
        private string thoiGianBatDau;
        private string thoiGianKetThuc;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string TenCaThucHanh
        {
            get { return tenCaThucHanh; }
            set { tenCaThucHanh = value; }
        }
        public string ThoiGianBatDau
        {
            get { return thoiGianBatDau; }
            set { thoiGianBatDau = value; }
        }
        public string ThoiGianKetThuc
        {
            get { return thoiGianKetThuc; }
            set { thoiGianKetThuc = value; }
        }
        public CaThucHanh(int id, string ten, string batdau, string ketthuc)
        {
            this.id = id;
            this.tenCaThucHanh = ten;
            this.thoiGianBatDau = batdau;
            this.thoiGianKetThuc = ketthuc;
        }
        public CaThucHanh(DataRow row)
        {
            this.id = (int)row["id"];
            this.tenCaThucHanh = row["tenCaThucHanh"].ToString();
            this.thoiGianBatDau = row["thoiGianBatDau"].ToString();
            this.thoiGianKetThuc = row["thoiGianKetThuc"].ToString();
        }
    }
}
