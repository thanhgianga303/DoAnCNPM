using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class TaiKhoanService : ITaiKhoanService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public TaiKhoanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public TaiKhoanVM GetTaiKhoanViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSTaiKhoan = _unitOfWork.DanhSachTaiKhoan.GetViewDSTaiKhoan(SearchString, Genre);
            return new TaiKhoanVM
            {
                DanhSachTaiKhoan = PaginatedList<TaiKhoan>.Create(DSTaiKhoan, pageIndex, pageSize),
            };
        }
        public TaiKhoan GetTaiKhoan(int id)
        {
            var _TaiKhoan = _unitOfWork.DanhSachTaiKhoan.GetBy(id);
            return _TaiKhoan;
        }

        public void DeleteTaiKhoan(int id)
        {
            var TaiKhoan = _unitOfWork.DanhSachTaiKhoan.GetBy(id);
            if (TaiKhoan != null)
            {
                _unitOfWork.DanhSachTaiKhoan.Remove(TaiKhoan);
                _unitOfWork.Complete();
            }
        }
        // public string GetMd5Hash(Md5 md5, string input)
        // {
        //     byte[] bytes= md5.ComputerHash(v)
        // }
        public void AddTaiKhoan(TaiKhoan TaiKhoan)
        {
            _unitOfWork.DanhSachTaiKhoan.Add(TaiKhoan);
            _unitOfWork.Complete();
        }
        public bool KiemTraTaiKhoan(string username, string password)
        {
            var _TaiKhoan = _unitOfWork.DanhSachTaiKhoan.GetTaiKhoan(username, password);
            if (_TaiKhoan != null)
            {
                return true;
            }
            return false;
        }
        public TaiKhoan TaiKhoanKiemTra(string username, string password)
        {
            var _TaiKhoan = _unitOfWork.DanhSachTaiKhoan.GetTaiKhoan(username, password);
            return _TaiKhoan;
        }
        public void UpdateTaiKhoan(int id, TaiKhoan TaiKhoan)
        {
            var _TaiKhoan = _unitOfWork.DanhSachTaiKhoan.GetBy(id);
            if (_TaiKhoan != null)
            {
                _TaiKhoan.TenTaiKhoan = TaiKhoan.TenTaiKhoan;
                _TaiKhoan.MatKhau = TaiKhoan.MatKhau;
                _TaiKhoan.TrangThai = TaiKhoan.TrangThai;
            }
            _unitOfWork.Complete();
        }
    }
}