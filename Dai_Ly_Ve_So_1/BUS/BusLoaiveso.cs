using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.BUS
{
    class BusLoaiveso
    {
       public  List<LoaiVeso> GetAll()
       {
            QLVESODataContext db = new QLVESODataContext();
            return db.LoaiVesos.ToList();
        }
      
        public LoaiVeso GetByMa(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.LoaiVesos.Where(a => a.MaLoaiVeSo == ma).SingleOrDefault();
        }
    }
}
