using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.BUS
{
    class BusPhathanh
    {
        DALPhatHanh dALPhatHanh = new DALPhatHanh();
        public List<PhatHanh> GetAll()
        {
            return dALPhatHanh.GetAll();
        }
        public List<PhanPhoi> GetAll_Phanphoi()
        {
            return dALPhatHanh.GetAll_PhanPhoi();
        }

        public PhatHanh GetByMa(String ma)
        {
            return dALPhatHanh.GetByMa(ma);
        }
        public IEnumerable<String> get_Maphathanh()
        {
            return dALPhatHanh.get_MaPhatHanh();

        }
        public IEnumerable<String> get_Madaily()
        {
            return dALPhatHanh.get_Madaily();

        }
        public IEnumerable<String> get_Maloaiveso()
        {
            return dALPhatHanh.get_Maveso();

        }
        public bool Insert_Phathanh(PhatHanh a)
        {
            try
            {
                dALPhatHanh.insert_Phathanh(a);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_phathanh(PhatHanh a)
        {
            try
            {
                dALPhatHanh.update_PhatHanh(a);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete_PhatHanh(String a)
        {
            try
            {
                dALPhatHanh.delete_Phathanh(a);
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
        public bool Exits_Phathanh_byMa(string ma)
        {
            return dALPhatHanh.Exits_Phathanh_byMa(ma);
        }
    }
}
