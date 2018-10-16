using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
    class DALSoLuongDk
    {
        QLVESODataContext db = new QLVESODataContext();
        public List<SoLuongDK> GetAll()
        {
     
            return db.SoLuongDKs.ToList();
        }

        public SoLuongDK GetByMa(String ma)
        {
            return db.SoLuongDKs.Where(a => a.ID == ma).SingleOrDefault();
        }
        public bool Exits_SoLuongDK_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<String> get_MaLoaiveso()
        {
            
            return db.LoaiVesos.AsEnumerable().Select(s => s.MaLoaiVeSo);

        }
        public IEnumerable<String> get_Madaily()
        {

            return db.DaiLies.AsEnumerable().Select(s => s.MaDaiLy);

        }
        public void insert_SoLuongDk(SoLuongDK a)
        {
            QLVESODataContext db = new QLVESODataContext();
            db.SoLuongDKs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_SoLuongDk(SoLuongDK a)
        {
            QLVESODataContext db = new QLVESODataContext();
            SoLuongDK b = db.SoLuongDKs.Where(x => x.ID == a.ID).Single();
            b.MaLoaiveSo = a.MaLoaiveSo;
            b.MaDaiLy = a.MaDaiLy;
            b.NgayDK = a.NgayDK;
            b.SoLuongDK1 = a.SoLuongDK1;
            db.SubmitChanges();
        }
        public void delete_SoLuongDk(string ID)
        {
            QLVESODataContext db = new QLVESODataContext();
            SoLuongDK b = db.SoLuongDKs.Where(a => a.ID == ID).Single();
            db.SoLuongDKs.DeleteOnSubmit(b);
            db.SubmitChanges();

        }
        //public IEnumerable<CongNo> GetCongNosbyMaDaily(String ma)
        //{
        //    QLVESODataContext db = new QLVESODataContext();
        //    return db.CongNos.Where(a => a.MaDaiLy == ma).ToList();
        //}
    }
}
