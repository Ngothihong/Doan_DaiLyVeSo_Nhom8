using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.BUS
{
    class BusCongNo
    {
        DALCongNo dALCongNo = new DALCongNo();
        public List<CongNo> GetAll()
        {
            return dALCongNo.GetAll();
        }

        public CongNo GetByMa(String ma)
        {
            return dALCongNo.GetByMa(ma);
        }
        public bool Exits_CongNos_byMa(string ma)
        {
            return dALCongNo.Exits_CongNos_byMa(ma);
        }

        public IEnumerable<String> get_Maphathanh()
        {
            return dALCongNo.get_Maphathanh();

        }
        public IEnumerable<String> get_Madaily()
        {
            return dALCongNo.get_Madaily();

        }
        public void insert_CongNos(CongNo a)
        {
             dALCongNo.insert_CongNos(a);
        }
        public void update_CongNos(CongNo a)
        {
            dALCongNo.update_CongNos(a);
        }
        public void delete_CongNos(string macongno)
        {
            dALCongNo.delete_CongNos(macongno);

        }
    }
}
