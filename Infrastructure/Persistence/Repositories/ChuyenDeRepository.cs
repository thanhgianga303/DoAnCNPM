using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class ChuyenDeRepository : Repository<ChuyenDe>, IChuyenDeRepository
    {
        public ChuyenDeRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<ChuyenDe> GetViewDSChuyenDe(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachChuyenDe
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.MaChuyenDe.Contains(search)
                    || m.KhuVuc.Contains(search) || m.TrangThai.ToString().Contains(search)
                    || m.ChuyenDeID.ToString().Contains(search));
                }
                else
                if (genre == "MaChuyenDe")
                {
                    ds = ds.Where(m => m.MaChuyenDe.Contains(search));
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