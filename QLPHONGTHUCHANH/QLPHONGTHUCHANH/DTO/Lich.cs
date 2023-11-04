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
        private int maloaimon;
        private string tenloai;
        public int Maloaimon
        {
            get { return maloaimon; }
            set { maloaimon = value; }
        }
        public string Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }
        public Lich(int maloai, string tenloai)
        {
            this.maloaimon = maloai;
            this.tenloai = tenloai;
        }
        public Lich(DataRow row)
        {
            this.maloaimon = (int)row["maloaimon"];
            this.tenloai = row["tenloaimon"].ToString();
        }
    }
}
