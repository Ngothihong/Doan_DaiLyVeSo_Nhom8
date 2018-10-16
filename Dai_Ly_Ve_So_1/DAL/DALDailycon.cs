using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
   public class DALDailycon
    {
       // QLVESODataContext db = new QLVESODataContext();
        public List<DaiLy> GetAll()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.DaiLies.ToList();
        }

        public DaiLy GetByMa(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.DaiLies.Where(a => a.MaDaiLy == ma).SingleOrDefault();
        }
        public bool Exits_Daily_byMa( string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<String> getTenDaily()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.DaiLies.AsEnumerable().Select(s => s.MaDaiLy);

        }
        public void insert_Daily (DaiLy a)
        {
            QLVESODataContext db = new QLVESODataContext();
            db.DaiLies.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_Daily(DaiLy a)
        {
            QLVESODataContext db = new QLVESODataContext();
            DaiLy b = db.DaiLies.Where(x => x.MaDaiLy == a.MaDaiLy).Single();
            b.TenDaiLy = a.TenDaiLy;
            b.SDT = a.SDT;
            b.DiaChi = a.DiaChi;
            b.flag = a.flag;

            db.SubmitChanges();
        }
        public void delete_DaiLy( string Madaily)
        {
            QLVESODataContext db = new QLVESODataContext();
            DaiLy b = db.DaiLies.Where(a => a.MaDaiLy == Madaily).Single();
            db.DaiLies.DeleteOnSubmit(b);
            db.SubmitChanges();

        }
        public IEnumerable<CongNo> GetCongNosbyMaDaily(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.CongNos.Where(a => a.MaDaiLy == ma).ToList();
        }
    }
}
