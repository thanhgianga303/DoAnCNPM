using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence.Repositories
{
    public class NguoiDieuKhienRepository : Repository<NguoiDieuKhien>, INguoiDieuKhienRepository
    {
        public NguoiDieuKhienRepository(HeThongQuanLyVPGTContext context) : base(context)
        {
        }
        public IEnumerable<NguoiDieuKhien> GetViewDSNguoiDieuKhien(string search, string genre)
        {
            var dskv = from m in HeThongQuanLyVPGTContext.DanhSachNguoiDieuKhien
                       select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    dskv = dskv.Where(m => m.Ten.Contains(search)
                     || m.Cmnd.Contains(search)
                     || m.NgaySinh.ToString().Contains(search)
                     || m.DiaChi.Contains(search));
                }
                else
                if (genre == "Cmnd")
                {
                    dskv = dskv.Where(m => m.Cmnd.ToString().Contains(search));
                }
                else
                if (genre == "DiaChi")
                {
                    dskv = dskv.Where(m => m.DiaChi.ToString().Contains(search));
                }
                if (genre == "NgaySinh")
                {
                    dskv = dskv.Where(m => m.NgaySinh.ToString().Contains(search));
                }
                else
                if (genre == "Ten")
                {
                    dskv = dskv.Where(m => m.Ten.Contains(search));
                }
            }
            return dskv.ToList();
        }
        protected HeThongQuanLyVPGTContext HeThongQuanLyVPGTContext
        {
            get { return Context as HeThongQuanLyVPGTContext; }
        }
    }
}