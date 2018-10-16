using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.BUS
{
    class BusSoLuongDangKy
    {
        DALSoLuongDk dalSoLuongDk = new DALSoLuongDk();
        public List<SoLuongDK> GetAll()
        {
            return dalSoLuongDk.GetAll();
        }

        //public DaiLy GetByMa(String ma)
        //{
        //    return dalDailycon.GetByMa(ma);
        //}
        public IEnumerable<String> get_MaloaiveSo()
        {
            return dalSoLuongDk.get_MaLoaiveso();
        }
        public IEnumerable<String> get_Madaily()
        {
            return dalSoLuongDk.get_Madaily();
        }
        public bool Insert_SoLuongDk(SoLuongDK a)
        {
            try
            {
                dalSoLuongDk.insert_SoLuongDk(a);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_SoLuongDk(SoLuongDK a)
        {
            try
            {
                dalSoLuongDk.update_SoLuongDk(a);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete_SoLuongDk(String a)
        {
            try
            {
                dalSoLuongDk.delete_SoLuongDk(a);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public IEnumerable<CongNo> getCongNobyMadaily(string ma)
        //{
        //    return dalDailycon.GetCongNosbyMaDaily(ma);
        //}
        public bool Exits_SoLuongDK_byMa(string ma)
        {
            return dalSoLuongDk.Exits_SoLuongDK_byMa(ma);
        }
    }
}
