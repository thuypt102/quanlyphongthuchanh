using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DTO
{
    public class GV
    {

        public string Id { get; set; }
        public string TenGiangVien { get; set; }
        public string Khoa { get; set; }
        public string Sdt { get; set; }
        public bool? LuuTru { get; set; }
        public int IdTaiKhoan { get; set; }

        // Constructor
        public GV(string id, string tenGiangVien, string khoa, string sdt,int idTaiKhoan, bool? luuTru )
        {
            Id = id;
            TenGiangVien = tenGiangVien;
            Khoa = khoa;
            Sdt = sdt;
            LuuTru = luuTru;
            IdTaiKhoan = idTaiKhoan;
        }
    }
}
