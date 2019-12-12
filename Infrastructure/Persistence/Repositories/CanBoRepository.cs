using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class CanBoRepository : Repository<CanBo>, ICanBoRepository
    {
        public CanBoRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<CanBo> GetViewDSCanBo(string search, string genre)
        {
            var dscb = from m in HeThongQuanLyVPGTContext.DanhSachCanBo
                       select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    dscb = dscb.Where(m => m.MaCanBo.Contains(search)
                    || m.Ten.Contains(search));
                }
                else
                if (genre == "MaCanBo")
                {
                    dscb = dscb.Where(m => m.MaCanBo.Contains(search));
                }
                else
                if (genre == "Ten")
                {
                    dscb = dscb.Where(m => m.Ten.Contains(search));
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