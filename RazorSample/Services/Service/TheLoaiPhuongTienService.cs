using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;

namespace RazorSample.Services.Service
{
    public class TheLoaiPhuongTienService : ITheLoaiPhuongTienService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public TheLoaiPhuongTienService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public TheLoaiPhuongTienVM GetTheLoaiPhuongTienViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSTheLoaiPhuongTien = _unitOfWork.DanhSachTheLoaiPhuongTien.GetViewDSTheLoaiPhuongTien(SearchString, Genre);
            return new TheLoaiPhuongTienVM
            {
                DanhSachTheLoaiPhuongTien = PaginatedList<TheLoaiPhuongTien>.Create(DSTheLoaiPhuongTien, pageIndex, pageSize),
            };
        }
        public TheLoaiPhuongTien GetTheLoaiPhuongTien(int id)
        {
            var _TheLoaiPhuongTien = _unitOfWork.DanhSachTheLoaiPhuongTien.GetBy(id);
            return _TheLoaiPhuongTien;
        }

        public void DeleteTheLoaiPhuongTien(int id)
        {
            var TheLoaiPhuongTien = _unitOfWork.DanhSachTheLoaiPhuongTien.GetBy(id);
            if (TheLoaiPhuongTien != null)
            {
                _unitOfWork.DanhSachTheLoaiPhuongTien.Remove(TheLoaiPhuongTien);
                _unitOfWork.Complete();
            }
        }
        public void AddTheLoaiPhuongTien(TheLoaiPhuongTien TheLoaiPhuongTien)
        {
            _unitOfWork.DanhSachTheLoaiPhuongTien.Add(TheLoaiPhuongTien);
            _unitOfWork.Complete();
        }
        public void UpdateTheLoaiPhuongTien(int id, TheLoaiPhuongTien TheLoaiPhuongTien)
        {
            var _TheLoaiPhuongTien = _unitOfWork.DanhSachTheLoaiPhuongTien.GetBy(id);
            if (_TheLoaiPhuongTien != null)
            {
                _TheLoaiPhuongTien.TenTheLoai = TheLoaiPhuongTien.TenTheLoai;
                _TheLoaiPhuongTien.MaTheLoai = TheLoaiPhuongTien.MaTheLoai;
            }
            _unitOfWork.Complete();
        }
    }
}