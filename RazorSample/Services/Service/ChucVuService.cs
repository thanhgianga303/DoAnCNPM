using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class ChucVuService : IChucVuService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public ChucVuService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ChucVuVM GetChucVuViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSChucVu = _unitOfWork.DanhSachChucVu.GetViewDSChucVu(SearchString, Genre);
            return new ChucVuVM
            {
                DanhSachChucVu = PaginatedList<ChucVu>.Create(DSChucVu, pageIndex, pageSize),
            };
        }

        public void DeleteChucVu(int id)
        {
            var ChucVu = _unitOfWork.DanhSachChucVu.GetBy(id);
            if (ChucVu != null)
            {
                _unitOfWork.DanhSachChucVu.Remove(ChucVu);
                _unitOfWork.Complete();
            }
        }

        public void AddChucVu(ChucVu ChucVu)
        {
            _unitOfWork.DanhSachChucVu.Add(ChucVu);
            _unitOfWork.Complete();
        }
        public void UpdateChucVu(int id, ChucVu ChucVu)
        {
            var _ChucVu = _unitOfWork.DanhSachChucVu.GetBy(id);
            if (_ChucVu != null)
            {
                _ChucVu.MaChucVu = ChucVu.MaChucVu;
                _ChucVu.TenChucVu = ChucVu.TenChucVu;
            }
            _unitOfWork.Complete();
        }
        public ChucVu GetChucVu(int id)
        {
            var _ChucVu = _unitOfWork.DanhSachChucVu.GetBy(id);
            return _ChucVu;
        }
    }
}