using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
    class DALCongNo
    {
        public List<CongNo> GetAll()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.CongNos.ToList();
        }

        public CongNo GetByMa(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.CongNos.Where(a => a.MaCongNo == ma).SingleOrDefault();
        }
        public bool Exits_CongNos_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
       
        public IEnumerable<String> get_Maphathanh()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhatHanhs.AsEnumerable().Select(s => s.MaPhatHanh);

        }
        public IEnumerable<String> get_Madaily()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.DaiLies.AsEnumerable().Select(s => s.MaDaiLy);

        }
        public void insert_CongNos(CongNo a)
        {
            QLVESODataContext db = new QLVESODataContext();
            db.CongNos.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_CongNos(CongNo a)
        {
            QLVESODataContext db = new QLVESODataContext();
           CongNo b = db.CongNos.Where(x => x.MaCongNo== a.MaCongNo).Single();
            b.MaPhatHanh = a.MaPhatHanh;
            b.MaDaiLy = a.MaDaiLy;
            b.TongSoTien = a.TongSoTien;
            b.SoTienConNo = a.SoTienConNo;

            db.SubmitChanges();
        }
        public void delete_CongNos(string macongno)
        {
            QLVESODataContext db = new QLVESODataContext();
            CongNo b = db.CongNos.Where(a => a.MaCongNo == macongno).Single();
            db.CongNos.DeleteOnSubmit(b);
            db.SubmitChanges();

        }
        
    }
}
