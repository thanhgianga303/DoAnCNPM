using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class PhuongTienRepository : Repository<PhuongTien>, IPhuongTienRepository
    {
        public PhuongTienRepository(HeThongQuanLyVPGTContext context) : base(context)
        {
        }
        // public PhuongTien GetPhuongTien(string search, string loaixe)
        // {
        //     var query = HeThongQuanLyVPGTContext.DanhSachPhuongTien
        //                 .Include("DanhSachBienBan");
        //     if (!string.IsNullOrEmpty(search))
        //     {
        //         query = query.Where(m => m.LoaiXe.Contains(loaixe))
        //                    .Where(m => m.BKS.Contains(search));
        //     }
        //     else
        //     {
        //         query = query
        //             .Where(m => m.BKS.Equals(""));

        //     }
        //     return query.SingleOrDefault();
        // }
        public IEnumerable<PhuongTien> GetViewDSPhuongTien(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachPhuongTien
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.CaVet.Contains(search)
                    || m.BKS.Contains(search));
                }
                else
                if (genre == "CaVet")
                {
                    ds = ds.Where(m => m.CaVet.Contains(search));
                }
                else
                if (genre == "BKS")
                {
                    ds = ds.Where(m => m.BKS.Contains(search));
                }
            }
            return ds.ToList();
        }

        protected HeThongQuanLyVPGTContext HeThongQuanLyVPGTContext
        {
            get { return Context as HeThongQuanLyVPGTContext; }
        }
    }
}