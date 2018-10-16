using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
    class DALPhatHanh
    {
        public List<PhatHanh> GetAll()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhatHanhs.ToList();
        }
        public List<PhanPhoi> GetAll_PhanPhoi()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhanPhois.ToList();
        }
        public PhatHanh GetByMa(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhatHanhs.Where(a => a.MaPhatHanh == ma).SingleOrDefault();
        }
        public bool Exits_Phathanh_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<String> get_MaPhatHanh()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhatHanhs.AsEnumerable().Select(s => s.MaPhatHanh);

        }
        public IEnumerable<String> get_Madaily()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.DaiLies.AsEnumerable().Select(s => s.MaDaiLy);

        }
        public IEnumerable<String> get_Maveso()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.LoaiVesos.AsEnumerable().Select(s => s.MaLoaiVeSo);

        }
        public void insert_Phathanh(PhatHanh a)
        {
            QLVESODataContext db = new QLVESODataContext();
            db.PhatHanhs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_PhatHanh(PhatHanh a)
        {
            QLVESODataContext db = new QLVESODataContext();
            PhatHanh b = db.PhatHanhs.Where(x => x.MaPhatHanh == a.MaPhatHanh).Single();
            b.NgayPhatHanh = a.NgayPhatHanh;
            b.SLBan = a.SLBan;
            b.SoLuong = a.SoLuong;
            b.DoanhThuDPH = a.DoanhThuDPH;
            b.HoaHong = a.HoaHong;
            b.TienThanhToan = a.TienThanhToan;
            db.SubmitChanges();
        }
        public void delete_Phathanh(string Maphathanh)
        {
            QLVESODataContext db = new QLVESODataContext();
           PhatHanh b = db.PhatHanhs.Where(a => a.MaPhatHanh == Maphathanh).Single();
            db.PhatHanhs.DeleteOnSubmit(b);
            db.SubmitChanges();

        }
        //public IEnumerable<CongNo> GetCongNosbyMaDaily(String ma)
        //{
        //    QLVESODataContext db = new QLVESODataContext();
        //    return db.CongNos.Where(a => a.MaDaiLy == ma).ToList();
        //}
    }
}
