using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DTO
{
    public class Phong
    {
        
            public string Id { get; set; }
            public string TenPhong { get; set; }
            public string TenKhuVuc { get; set; }
            public int SoLuongMay { get; set; }
            public string  LoaiThucHanh { get; set; }
            public bool? LuuTru { get; set; }

            public Phong(string id, string tenPhong, string tenKhuVuc, int soLuongMay, string loaiThucHanh, bool? luuTru)
            {
                Id = id;
                TenPhong = tenPhong;
                TenKhuVuc = tenKhuVuc;
                SoLuongMay = soLuongMay;
                LoaiThucHanh = loaiThucHanh;
                LuuTru = luuTru;
            }
        }
    
}
