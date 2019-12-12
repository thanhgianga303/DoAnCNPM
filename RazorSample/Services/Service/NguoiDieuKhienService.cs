using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class NguoiDieuKhienService : INguoiDieuKhienService
    {
        private readonly IUnitOfWork _unitOfWork;
        private int pageSize = 3;
        public NguoiDieuKhienService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public NguoiDieuKhienVM GetNguoiDieuKhienViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSNguoiDieuKhien = _unitOfWork.DanhSachNguoiDieuKhien.GetViewDSNguoiDieuKhien(SearchString, Genre);

            return new NguoiDieuKhienVM
            {
                DanhSachNguoiDieuKhien = PaginatedList<NguoiDieuKhien>.Create(DSNguoiDieuKhien, pageIndex, pageSize)
            };
        }
        public void AddNguoiDieuKhien(NguoiDieuKhien NguoiDieuKhien)
        {
            _unitOfWork.DanhSachNguoiDieuKhien.Add(NguoiDieuKhien);
            _unitOfWork.Complete();
        }
        public void DeleteNguoiDieuKhien(int id)
        {
            var _NguoiDieuKhien = _unitOfWork.DanhSachNguoiDieuKhien.GetBy(id);
            if (_NguoiDieuKhien != null)
            {
                _unitOfWork.DanhSachNguoiDieuKhien.Remove(_NguoiDieuKhien);
                _unitOfWork.Complete();
            }
        }
        public void UpdateNguoiDieuKhien(int id, NguoiDieuKhien NguoiDieuKhien)
        {
            var _NguoiDieuKhien = _unitOfWork.DanhSachNguoiDieuKhien.GetBy(id);
            if (_NguoiDieuKhien != null)
            {
                _NguoiDieuKhien.Cmnd = NguoiDieuKhien.Cmnd;
                _NguoiDieuKhien.Ten = NguoiDieuKhien.Ten;
                _NguoiDieuKhien.NgaySinh = NguoiDieuKhien.NgaySinh;
                _NguoiDieuKhien.DiaChi = NguoiDieuKhien.DiaChi;
            }
            _unitOfWork.Complete();
        }
        public NguoiDieuKhien GetNguoiDieuKhien(int id)
        {
            var _NguoiDieuKhien = _unitOfWork.DanhSachNguoiDieuKhien.GetBy(id);
            return _NguoiDieuKhien;
        }
    }
}