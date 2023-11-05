using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DTO
{
    public class Lich
    {
        private int id;
        private int idCaThucHanh;
        private string idLop;
        private string idPhong;
        private string idGiangVien;
        private string namHoc;
        private int kiHoc;
        private string thu;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdCaThucHanh
        {
            get { return idCaThucHanh; }
            set { idCaThucHanh = value; }
        }
        public string IdLop
        {
            get { return idLop; }
            set { idLop = value; }
        }
        public string IdPhong
        {
            get { return idPhong; }
            set { idPhong = value; }
        }
        public string IdGiangVien
        {
            get { return idGiangVien; }
            set { idGiangVien = value; }
        }
        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }
        public int KiHoc
        {
            get { return kiHoc; }
            set { kiHoc = value; }
        }
        public string Thu
        {
            get { return thu; }
            set { thu = value; }
        }
        public Lich(int id, int idcath, string idlop, string idphong, string idgv, string namhoc, int kihoc, string thu)
        {
            this.id = id;
            this.idCaThucHanh = idcath;
            this.idLop = idlop;
            this.idPhong = idphong;
            this.idGiangVien = idgv;
            this.namHoc = namhoc;
            this.kiHoc = kihoc;
            this.thu = thu;
        }

        public Lich(DataRow row)
        {
            this.id = (int)row["id"];
            this.idCaThucHanh = (int)row["idCaThucHanh"];
            this.idLop = row["idLop"].ToString();
            this.idPhong = row["idPhong"].ToString();
            this.idGiangVien = row["idGiangVien"].ToString(); ;
            this.namHoc = row["namHoc"].ToString();
            this.kiHoc = (int)row["kiHoc"];
            this.thu = row["thu"].ToString();
        }
    }
}
