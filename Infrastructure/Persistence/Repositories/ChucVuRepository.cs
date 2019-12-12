using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class ChucVuRepository : Repository<ChucVu>, IChucVuRepository
    {
        public ChucVuRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<ChucVu> GetViewDSChucVu(string search, string genre)
        {
            var dscb = from m in HeThongQuanLyVPGTContext.DanhSachChucVu
                       select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    dscb = dscb.Where(m => m.MaChucVu.Contains(search)
                    || m.TenChucVu.Contains(search));
                }
                else
                if (genre == "MaChucVu")
                {
                    dscb = dscb.Where(m => m.MaChucVu.Contains(search));
                }
                else
                if (genre == "TenChucVu")
                {
                    dscb = dscb.Where(m => m.TenChucVu.Contains(search));
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