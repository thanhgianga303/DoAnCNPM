using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class DieuLuatRepository : Repository<DieuLuat>, IDieuLuatRepository
    {
        public DieuLuatRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<DieuLuat> GetViewDSDieuLuat(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachDieuLuat
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.MaDieuLuat.Contains(search)
                    || m.Ten.Contains(search));
                }
                else
                if (genre == "MaDieuLuat")
                {
                    ds = ds.Where(m => m.MaDieuLuat.Contains(search));
                }
                else
                if (genre == "TenDieuLuat")
                {
                    ds = ds.Where(m => m.Ten.Contains(search));
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