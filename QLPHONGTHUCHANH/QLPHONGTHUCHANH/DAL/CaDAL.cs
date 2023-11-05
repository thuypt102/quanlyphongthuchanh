using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPHONGTHUCHANH.DAL
{
    public class CaDAL
    {
        private static CaDAL khoitao;

        public static CaDAL Khoitao
        {
            get
            {
                if (khoitao == null)
                    khoitao = new CaDAL();
                return CaDAL.khoitao;
            }
            private set { CaDAL.khoitao = value; }
        }
        public List<CaThucHanh> loadCa()
        {
            List<CaThucHanh> list = new List<CaThucHanh>();
            string query = "SELECT * FROM CATHUCHANH WHERE id IN (SELECT DISTINCT id FROM CATHUCHANH)";
            DataTable dta = DataProvider.Khoitao.ExecuteQuery(query);

            foreach (DataRow item in dta.Rows)
            {
                CaThucHanh ca = new CaThucHanh(item);
                list.Add(ca);
            }
            return list;
        }
    }
}
