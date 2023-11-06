using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DTO
{
    public class GV
    {

            private string id;
            private string tenGiangVien;
            private string khoa;
            private string sdt;
            private bool? luuTru;
            private int idTaiKhoan;

            public string Id
            {
                get { return id; }
                set { id = value; }
            }
            public string TenGiangVien
        {
                get { return tenGiangVien; }
                set { tenGiangVien = value; }
            }
            public string Khoa
        {
                get { return khoa; }
                set { khoa = value; }
            }
            public string Sdt
        {
                get { return sdt; }
                set { sdt = value; }
            }
            public int IdTaiKhoan
            {
                get { return idTaiKhoan; }
                set { idTaiKhoan = value; }
            }
            
            public bool? LuuTru
            {
                get { return luuTru; }
                set { luuTru = value; }
            }


        public GV(string id, string tenGiangVien, string khoa, string sdt,
           int idTaiKhoan, bool? luuTru)
        {
            this.id = id;
            this.tenGiangVien = tenGiangVien;
            this.khoa = khoa;
            this.sdt = sdt;
            this.luuTru = luuTru;
            this.idTaiKhoan = idTaiKhoan;
        }
                

            
        }
}
