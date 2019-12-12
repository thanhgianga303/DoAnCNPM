using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
namespace Infrastructure.Persistence.Repositories
{
    public class TuyenDuongRepository : Repository<TuyenDuong>, ITuyenDuongRepository
    {
        public TuyenDuongRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public IEnumerable<TuyenDuong> GetViewDSTuyenDuong(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachTuyenDuong
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.TuyenDuongID.ToString().Contains(search)
                    || m.TenTuyenDuong.ToString().Contains(search)
                    || m.KhuVucID.ToString().Contains(search));
                }
                else
                if (genre == "TuyenDuongID")
                {
                    ds = ds.Where(m => m.TuyenDuongID.ToString().Contains(search));
                }
                else
                if (genre == "KhuVucID")
                {
                    ds = ds.Where(m => m.KhuVucID.ToString().Contains(search));
                }
                else
                if (genre == "TenTuyenDuong")
                {
                    ds = ds.Where(m => m.TenTuyenDuong.Contains(search));
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