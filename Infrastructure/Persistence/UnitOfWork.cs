using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repositories;

namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HeThongQuanLyVPGTContext _context;

        public UnitOfWork(HeThongQuanLyVPGTContext context)
        {
            DanhSachBienBan = new BienBanRepository(context);
            DanhSachNguoiDieuKhien = new NguoiDieuKhienRepository(context);
            DanhSachPhuongTien = new PhuongTienRepository(context);
            DanhSachCanBo = new CanBoRepository(context);
            DanhSachBangLai = new BangLaiRepository(context);
            DanhSachCapBac = new CapBacRepository(context);
            DanhSachChucVu = new ChucVuRepository(context);
            DanhSachChuyenDe = new ChuyenDeRepository(context);
            DanhSachDieuLuat = new DieuLuatRepository(context);
            DanhSachDoi = new DoiRepository(context);
            DanhSachQuyen = new QuyenRepository(context);
            DanhSachTaiKhoan = new TaiKhoanRepository(context);
            DanhSachTuyenDuong = new TuyenDuongRepository(context);
            DanhSachKhuVuc = new KhuVucRepository(context);
            DanhSachTheLoaiPhuongTien = new TheLoaiPhuongTienRepository(context);
            _context = context;
        }

        public IBienBanRepository DanhSachBienBan { get; private set; }
        public IPhuongTienRepository DanhSachPhuongTien { get; private set; }
        public INguoiDieuKhienRepository DanhSachNguoiDieuKhien { get; private set; }
        public IBangLaiRepository DanhSachBangLai { get; private set; }
        public ICanBoRepository DanhSachCanBo { get; private set; }
        public ICapBacRepository DanhSachCapBac { get; private set; }
        public IChucVuRepository DanhSachChucVu { get; private set; }
        public IChuyenDeRepository DanhSachChuyenDe { get; private set; }
        public IDieuLuatRepository DanhSachDieuLuat { get; private set; }
        public IDoiRepository DanhSachDoi { get; private set; }
        public IQuyenRepository DanhSachQuyen { get; private set; }
        public ITaiKhoanRepository DanhSachTaiKhoan { get; private set; }
        public ITuyenDuongRepository DanhSachTuyenDuong { get; private set; }
        public IKhuVucRepository DanhSachKhuVuc { get; private set; }
        public ITheLoaiPhuongTienRepository DanhSachTheLoaiPhuongTien { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}