using System;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBangLaiRepository DanhSachBangLai { get; }
        IBienBanRepository DanhSachBienBan { get; }
        ICanBoRepository DanhSachCanBo { get; }
        ICapBacRepository DanhSachCapBac { get; }
        IChucVuRepository DanhSachChucVu { get; }
        IChuyenDeRepository DanhSachChuyenDe { get; }
        IDieuLuatRepository DanhSachDieuLuat { get; }
        ITuyenDuongRepository DanhSachTuyenDuong { get; }
        IKhuVucRepository DanhSachKhuVuc { get; }
        ITheLoaiPhuongTienRepository DanhSachTheLoaiPhuongTien { get; }
        IDoiRepository DanhSachDoi { get; }
        INguoiDieuKhienRepository DanhSachNguoiDieuKhien { get; }
        IPhuongTienRepository DanhSachPhuongTien { get; }
        IQuyenRepository DanhSachQuyen { get; }
        ITaiKhoanRepository DanhSachTaiKhoan { get; }
        int Complete();
    }
}