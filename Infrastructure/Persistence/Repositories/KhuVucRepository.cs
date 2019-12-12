using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence.Repositories
{
    public class KhuVucRepository : Repository<KhuVuc>, IKhuVucRepository
    {
        public IEnumerable<KhuVuc> GetViewDSKhuVuc(string search, string genre)
        {
            var dskv = from m in HeThongQuanLyVPGTContext.DanhSachKhuVuc
                       select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    dskv = dskv.Where(m => m.MaKhuVuc.Contains(search)
                     || m.TenKhuVuc.Contains(search)
               );
                }
                else
                if (genre == "MaKhuVuc")
                {
                    dskv = dskv.Where(m => m.MaKhuVuc.Contains(search));
                }
                else
                if (genre == "TenKhuVuc")
                {
                    dskv = dskv.Where(m => m.TenKhuVuc.Contains(search));
                }
            }
            return dskv.ToList();
        }
        public KhuVucRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        protected HeThongQuanLyVPGTContext HeThongQuanLyVPGTContext
        {
            get { return Context as HeThongQuanLyVPGTContext; }
        }
    }
}