using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class TheLoaiPhuongTienRepository : Repository<TheLoaiPhuongTien>, ITheLoaiPhuongTienRepository
    {
        public TheLoaiPhuongTienRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<TheLoaiPhuongTien> GetViewDSTheLoaiPhuongTien(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachTheLoaiPhuongTien
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.MaTheLoai.Contains(search)
                    || m.TenTheLoai.Contains(search));
                }
                else
                if (genre == "MaTheLoai")
                {
                    ds = ds.Where(m => m.MaTheLoai.ToString().Contains(search));
                }
                else
                if (genre == "TenTheLoai")
                {
                    ds = ds.Where(m => m.TenTheLoai.Contains(search));
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