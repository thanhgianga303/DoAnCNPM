using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class CapBacRepository : Repository<CapBac>, ICapBacRepository
    {
        public CapBacRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<CapBac> GetViewDSCapBac(string search, string genre)
        {
            var dscb = from m in HeThongQuanLyVPGTContext.DanhSachCapBac
                       select m;
            if (!string.IsNullOrEmpty(search))
            {
                if (genre == "All")
                {
                    dscb = dscb.Where(m => m.MaCapBac.Contains(search)
                    || m.TenCapBac.Contains(search));
                }
                else
                if (genre == "MaCapBac")
                {
                    dscb = dscb.Where(m => m.MaCapBac.Contains(search));
                }
                else
                if (genre == "TenCapBac")
                {
                    dscb = dscb.Where(m => m.TenCapBac.Contains(search));
                }
            }
            return dscb.ToList();
        }
        protected HeThongQuanLyVPGTContext HeThongQuanLyVPGTContext
        {
            get { return Context as HeThongQuanLyVPGTContext; }
        }
    }
}