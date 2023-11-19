using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLPHONGTHUCHANH.DTO
{
    public class GV
    {

        public string Id { get; set; }
        public string TenGiangVien { get; set; }
        public string Khoa { get; set; }
        public string Sdt { get; set; }
        public string email { get; set; }
        public bool? LuuTru { get; set; }
        public int IdTaiKhoan { get; set; }

        // Constructor
        public GV(string id, string tenGiangVien, string khoa, string sdt, string Email, int idTaiKhoan/*, bool? luuTru*/)
        {
            Id = id;
            TenGiangVien = tenGiangVien;
            Khoa = khoa;
            Sdt = sdt;
            email = Email;
            IdTaiKhoan = idTaiKhoan;
            /*LuuTru = luuTru;*/
        }
    }
}
