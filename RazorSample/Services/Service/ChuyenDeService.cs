using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class ChuyenDeService : IChuyenDeService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public ChuyenDeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ChuyenDeVM GetChuyenDeViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSChuyenDe = _unitOfWork.DanhSachChuyenDe.GetViewDSChuyenDe(SearchString, Genre);
            return new ChuyenDeVM
            {
                DanhSachChuyenDe = PaginatedList<ChuyenDe>.Create(DSChuyenDe, pageIndex, pageSize),
            };
        }

        public void DeleteChuyenDe(int id)
        {
            var ChuyenDe = _unitOfWork.DanhSachChuyenDe.GetBy(id);
            if (ChuyenDe != null)
            {
                _unitOfWork.DanhSachChuyenDe.Remove(ChuyenDe);
                _unitOfWork.Complete();
            }
        }
        public void AddChuyenDe(ChuyenDe ChuyenDe)
        {
            _unitOfWork.DanhSachChuyenDe.Add(ChuyenDe);
            _unitOfWork.Complete();
        }
        public void UpdateChuyenDe(int id, ChuyenDe ChuyenDe)
        {
            var _ChuyenDe = _unitOfWork.DanhSachChuyenDe.GetBy(id);
            if (_ChuyenDe != null)
            {
                _ChuyenDe.MaChuyenDe = ChuyenDe.MaChuyenDe;
                _ChuyenDe.KhuVuc = ChuyenDe.KhuVuc;
                _ChuyenDe.NgayBatDau = ChuyenDe.NgayBatDau;
                _ChuyenDe.NgayKetThuc = ChuyenDe.NgayKetThuc;
                _ChuyenDe.TrangThai = ChuyenDe.TrangThai;
            }
            _unitOfWork.Complete();
        }
        public ChuyenDe GetChuyenDe(int id)
        {
            var _ChuyenDe = _unitOfWork.DanhSachChuyenDe.GetBy(id);
            return _ChuyenDe;
        }
    }
}