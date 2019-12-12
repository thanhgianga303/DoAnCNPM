using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence
{
    public class HeThongQuanLyVPGTContext : DbContext
    {
        public HeThongQuanLyVPGTContext(DbContextOptions<HeThongQuanLyVPGTContext> options) : base(options)
        {

        }
        public DbSet<BangLai> DanhSachBangLai { get; set; }
        public DbSet<BienBan> DanhSachBienBan { get; set; }
        public DbSet<CapBac> DanhSachCapBac { get; set; }
        public DbSet<CanBo> DanhSachCanBo { get; set; }
        public DbSet<ChiTietBienBan> DanhSachChiTietBienBan { get; set; }
        public DbSet<ChucVu> DanhSachChucVu { get; set; }
        public DbSet<ChuyenDe> DanhSachChuyenDe { get; set; }
        public DbSet<DieuLuat> DanhSachDieuLuat { get; set; }
        public DbSet<Doi> DanhSachDoi { get; set; }
        public DbSet<TuyenDuong> DanhSachTuyenDuong { get; set; }
        public DbSet<KhuVuc> DanhSachKhuVuc { get; set; }
        public DbSet<TheLoaiPhuongTien> DanhSachTheLoaiPhuongTien { get; set; }
        public DbSet<NguoiDieuKhien> DanhSachNguoiDieuKhien { get; set; }
        public DbSet<PhuongTien> DanhSachPhuongTien { get; set; }
        public DbSet<TaiKhoan> DanhSachTaiKhoan { get; set; }
        public DbSet<Quyen> DanhSachQuyen { get; set; }
    }
}