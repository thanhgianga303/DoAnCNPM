using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;

namespace RazorSample.Services.Service
{
    public class TuyenDuongService : ITuyenDuongService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public TuyenDuongService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public TuyenDuongVM GetTuyenDuongViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSTuyenDuong = _unitOfWork.DanhSachTuyenDuong.GetViewDSTuyenDuong(SearchString, Genre);
            return new TuyenDuongVM
            {
                DanhSachTuyenDuong = PaginatedList<TuyenDuong>.Create(DSTuyenDuong, pageIndex, pageSize),
            };
        }
        public TuyenDuong GetTuyenDuong(int id)
        {
            var _TuyenDuong = _unitOfWork.DanhSachTuyenDuong.GetBy(id);
            return _TuyenDuong;
        }

        public void DeleteTuyenDuong(int id)
        {
            var TuyenDuong = _unitOfWork.DanhSachTuyenDuong.GetBy(id);
            if (TuyenDuong != null)
            {
                _unitOfWork.DanhSachTuyenDuong.Remove(TuyenDuong);
                _unitOfWork.Complete();
            }
        }
        public void AddTuyenDuong(TuyenDuong TuyenDuong)
        {
            _unitOfWork.DanhSachTuyenDuong.Add(TuyenDuong);
            _unitOfWork.Complete();
        }
        public void UpdateTuyenDuong(int id, TuyenDuong TuyenDuong)
        {
            var _TuyenDuong = _unitOfWork.DanhSachTuyenDuong.GetBy(id);
            if (_TuyenDuong != null)
            {
                _TuyenDuong.TenTuyenDuong = TuyenDuong.TenTuyenDuong;
                _TuyenDuong.MaTuyenDuong = TuyenDuong.MaTuyenDuong;
                _TuyenDuong.KhuVucID = TuyenDuong.KhuVucID;
            }
            _unitOfWork.Complete();
        }
    }
}