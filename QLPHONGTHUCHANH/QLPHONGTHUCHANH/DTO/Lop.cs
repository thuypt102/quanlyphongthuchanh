using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLPHONGTHUCHANH.DTO
{
    public class Lop
    {
        private string id;
        private string tenLop;
        private string tenKhoa;
        private string idGiangVienPhuTrach;
        private string caLyThuyet;
        private int soLuongSinhVien;
        private int loaiThucHanh;
        private bool? luuTru;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
        public string IdGiangVienPhuTrach
        {
            get { return idGiangVienPhuTrach; }
            set { idGiangVienPhuTrach = value; }
        }
        public string CaLyThuyet
        {
            get { return caLyThuyet; }
            set { caLyThuyet = value; }
        }
        public int SoLuongSinhVien
        {
            get { return soLuongSinhVien; }
            set { soLuongSinhVien = value; }
        }
        public int LoaiThucHanh
        {
            get { return loaiThucHanh; }
            set { loaiThucHanh = value; }
        }
        public bool? LuuTru
        {
            get { return luuTru; }
            set { luuTru = value; }
        }

        
        public Lop(string id, string tenLop, string tenKhoa, string idGiangVienPhuTrach,
            string caLyThuyet, int soLuongSinhVien, int loaiThucHanh, bool? luuTru)
        {
            this.id = id;
            this.tenLop = tenLop;
            this.tenKhoa = tenKhoa;
            this.idGiangVienPhuTrach = idGiangVienPhuTrach;
            this.caLyThuyet = caLyThuyet;
            this.soLuongSinhVien = soLuongSinhVien;
            this.loaiThucHanh = loaiThucHanh;
            this.luuTru = luuTru;

        }
        
    }
}
