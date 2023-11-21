using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DTO
{
    public class ThongBao
    {
        public string Id { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string IdGiangVien { get; set; }
        public string ThoiGianGui { get; set; }
        public bool? TrangThai { get; set; }
        

        // Constructor
        public ThongBao(string id, string tieuDe, string noiDung, string idGiangVien, string thoiGianGui, bool? trangThai)
        {
            Id = id;
            TieuDe = tieuDe;
            NoiDung = noiDung;
            IdGiangVien = idGiangVien;
            ThoiGianGui = thoiGianGui;
            TrangThai = trangThai;
        }
        public ThongBao(string id, string tieuDe, string noiDung, string idGiangVien, string thoiGianGui)
        {
            Id = id;
            TieuDe = tieuDe;
            NoiDung = noiDung;
            IdGiangVien = idGiangVien;
            ThoiGianGui = thoiGianGui;
        }
    }
}