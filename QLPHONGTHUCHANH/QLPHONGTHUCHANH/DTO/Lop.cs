using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DTO
{
    public class Lop
    {
        
            public string Id { get; set; }
            public string TenLop { get; set; }
            public string TenKhoa { get; set; }
            public string IdGiangVienPhuTrach { get; set; }
            public string CaLyThuyet { get; set; }
            public int SoLuongSinhVien { get; set; }
            public string LoaiThucHanh { get; set; }
            public bool? LuuTru { get; set; }

            // Constructor
            public Lop(string id, string tenLop, string tenKhoa, string idGiangVienPhuTrach, string caLyThuyet, int soLuongSinhVien, string loaiThucHanh, bool? luuTru)
            {
                Id = id;
                TenLop = tenLop;
                TenKhoa = tenKhoa;
                IdGiangVienPhuTrach = idGiangVienPhuTrach;
                CaLyThuyet = caLyThuyet;
                SoLuongSinhVien = soLuongSinhVien;
                LoaiThucHanh = loaiThucHanh;
                LuuTru = luuTru;
            }
     }
}
