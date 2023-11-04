using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DAL
{
    public class LichDAL
    {
        private static LichDAL khoitao;

        public static LichDAL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new LichDAL();
                return LichDAL.khoitao;
            }
            private set { LichDAL.khoitao = value; }
        }

        private LichDAL() { }

        public DataTable getLichThucHanh()
        {
            return DataProvider.Khoitao.ExecuteQuery("Select * from LICHTHUCHANH");
        }
    }
}
