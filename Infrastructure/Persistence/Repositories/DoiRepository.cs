using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class DoiRepository : Repository<Doi>, IDoiRepository
    {
        public DoiRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<Doi> GetViewDSDoi(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachDoi
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.MaDoi.Contains(search)
                    || m.TenDoi.Contains(search));
                }
                else
                if (genre == "MaDoi")
                {
                    ds = ds.Where(m => m.MaDoi.Contains(search));
                }
                else
                if (genre == "TenDoi")
                {
                    ds = ds.Where(m => m.TenDoi.Contains(search));
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