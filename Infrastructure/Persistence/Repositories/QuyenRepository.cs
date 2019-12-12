using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class QuyenRepository : Repository<Quyen>, IQuyenRepository
    {
        public QuyenRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<Quyen> GetViewDSQuyen(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachQuyen
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.MaQuyen.Contains(search)
                    || m.TenQuyen.Contains(search));
                }
                else
                if (genre == "MaQuyen")
                {
                    ds = ds.Where(m => m.MaQuyen.Contains(search));
                }
                else
                if (genre == "TenQuyen")
                {
                    ds = ds.Where(m => m.TenQuyen.Contains(search));
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