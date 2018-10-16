using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dai_Ly_Ve_So_1.DAL;
namespace Dai_Ly_Ve_So_1.BUS
{
    class BusDailycon
    {
        DALDailycon dalDailycon = new DALDailycon();
        public List<DaiLy> GetAll()
        {
            return dalDailycon.GetAll();
        }

        public DaiLy GetByMa(String ma)
        {
            return dalDailycon.GetByMa(ma);
        }
        public IEnumerable<String> getTenDaily()
        {
            return dalDailycon.getTenDaily();
            
        }
        public bool Insert_Daily(DaiLy a)
        {
            try
            {
                dalDailycon.insert_Daily(a);
                
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_Daily(DaiLy a)
        {
            try
            {
                dalDailycon.update_Daily(a);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete_Daily(String a)
        {
            try
            {
                dalDailycon.delete_DaiLy(a);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<CongNo> getCongNobyMadaily(string ma)
        {
            return dalDailycon.GetCongNosbyMaDaily(ma);
        }
         public bool Exits_DaiLy_byMa(string ma)
        {
            return dalDailycon.Exits_Daily_byMa(ma);
        }
    }
}
