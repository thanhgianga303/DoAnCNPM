using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class BienBanService : IBienBanService
    {
        private int pageSize = 10;
        private readonly IUnitOfWork _unitOfWork;

        public BienBanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public BienBanVM GetBienBanViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSBienBan = _unitOfWork.DanhSachBienBan.GetViewDSBienBan(SearchString, Genre);
            return new BienBanVM
            {
                DanhSachBienBan = PaginatedList<BienBan>.Create(DSBienBan, pageIndex, pageSize),
            };
        }
        public BienBanVM GetBienBanViewModelForUser(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSBienBan = _unitOfWork.DanhSachBienBan.GetViewDSBienBanForUser(SearchString, Genre);
            return new BienBanVM
            {
                DanhSachBienBan = PaginatedList<BienBan>.Create(DSBienBan, pageIndex, pageSize),
            };
        }
        public ChiTietBienBanVM GetChiTietBienBanViewModel(int id, int pageIndex = 1)
        {
            var DSChiTietBienBan = _unitOfWork.DanhSachBienBan.GetDanhSachChiTietBienBan(id);
            return new ChiTietBienBanVM
            {
                DanhSachChiTietBienBan = PaginatedList<ChiTietBienBan>.Create(DSChiTietBienBan, pageIndex, pageSize),
            };
        }
        public void DeleteBienBan(int id)
        {
            var bienban = _unitOfWork.DanhSachBienBan.GetBy(id);
            if (bienban != null)
            {
                _unitOfWork.DanhSachBienBan.Remove(bienban);
                _unitOfWork.Complete();
            }
        }
        public void DeleteChiTietBienBan(int id)
        {
            var ctbienban = _unitOfWork.DanhSachBienBan.GetByID(id);
            if (ctbienban != null)
            {
                _unitOfWork.DanhSachBienBan.RemoveChiTietBienBan(ctbienban);
                _unitOfWork.Complete();
            }
        }
        public void AddBienBan(BienBan BienBan)
        {
            _unitOfWork.DanhSachBienBan.Add(BienBan);
            _unitOfWork.Complete();
        }
        public void AddChiTietBienBan(ChiTietBienBan ChiTietBienBan)
        {
            _unitOfWork.DanhSachBienBan.AddChiTietBienBan(ChiTietBienBan);
            _unitOfWork.Complete();
        }
        public void UpdateBienBan(int id, BienBan BienBan)
        {
            var _BienBan = _unitOfWork.DanhSachBienBan.GetBy(id);
            if (_BienBan != null)
            {
                _BienBan.PhuongTienID = BienBan.PhuongTienID;
                _BienBan.NguoiDieuKhienID = BienBan.NguoiDieuKhienID;
                _BienBan.TuyenDuongID = BienBan.TuyenDuongID;
                _BienBan.MaBienBan = BienBan.MaBienBan;
                _BienBan.ThoiGian = BienBan.ThoiGian;
                _BienBan.TienPhat = BienBan.TienPhat;
            }
            _unitOfWork.Complete();
        }
        public void UpdateChiTietBienBan(int id, ChiTietBienBan ChiTietBienBan)
        {
            var _CTBienBan = _unitOfWork.DanhSachBienBan.GetByID(id);
            if (_CTBienBan != null)
            {
                _CTBienBan.MaChiTietBienBan = ChiTietBienBan.MaChiTietBienBan;
            }
            _unitOfWork.Complete();
        }
        public BienBan GetBienBan(int id)
        {
            var _BienBan = _unitOfWork.DanhSachBienBan.GetBy(id);
            return _BienBan;
        }
        public ChiTietBienBan GetChiTietBienBan(int id)
        {
            var _ChiTietBienBan = _unitOfWork.DanhSachBienBan.GetByID(id);
            return _ChiTietBienBan;
        }
    }
}