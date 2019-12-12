using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class TaiKhoanRepository : Repository<TaiKhoan>, ITaiKhoanRepository
    {
        public TaiKhoanRepository(HeThongQuanLyVPGTContext context) : base(context)
        {

        }
        public TaiKhoan GetTaiKhoan(string username, string password)
        {
            var ds = HeThongQuanLyVPGTContext.DanhSachTaiKhoan
                    .Include("CanBo")
                    .Include("Quyen");
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                ds = ds.Where(m => m.TenTaiKhoan.Equals(username) && m.MatKhau.Equals(password));
            }
            return ds.FirstOrDefault();
        }
        public IEnumerable<TaiKhoan> GetViewDSTaiKhoan(string search, string genre)
        {
            var ds = from m in HeThongQuanLyVPGTContext.DanhSachTaiKhoan
                     select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    ds = ds.Where(m => m.MatKhau.Contains(search)
                    || m.TenTaiKhoan.Contains(search));
                }
                else
                if (genre == "TenTaiKhoan")
                {
                    ds = ds.Where(m => m.TenTaiKhoan.Contains(search));
                }
                else
                if (genre == "MatKhau")
                {
                    ds = ds.Where(m => m.MatKhau.Contains(search));
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