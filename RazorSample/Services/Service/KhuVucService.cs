using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;

namespace RazorSample.Services.Service
{
    public class KhuVucService : IKhuVucService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public KhuVucService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public KhuVucVM GetKhuVucViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSKhuVuc = _unitOfWork.DanhSachKhuVuc.GetViewDSKhuVuc(SearchString, Genre);
            return new KhuVucVM
            {
                DanhSachKhuVuc = PaginatedList<KhuVuc>.Create(DSKhuVuc, pageIndex, pageSize),
            };
        }
        public KhuVuc GetKhuVuc(int id)
        {
            var _KhuVuc = _unitOfWork.DanhSachKhuVuc.GetBy(id);
            return _KhuVuc;
        }

        public void DeleteKhuVuc(int id)
        {
            var KhuVuc = _unitOfWork.DanhSachKhuVuc.GetBy(id);
            if (KhuVuc != null)
            {
                _unitOfWork.DanhSachKhuVuc.Remove(KhuVuc);
                _unitOfWork.Complete();
            }
        }
        public void AddKhuVuc(KhuVuc KhuVuc)
        {
            _unitOfWork.DanhSachKhuVuc.Add(KhuVuc);
            _unitOfWork.Complete();
        }
        public void UpdateKhuVuc(int id, KhuVuc KhuVuc)
        {
            var _KhuVuc = _unitOfWork.DanhSachKhuVuc.GetBy(id);
            if (_KhuVuc != null)
            {
                _KhuVuc.TenKhuVuc = KhuVuc.TenKhuVuc;
                _KhuVuc.MaKhuVuc = KhuVuc.MaKhuVuc;
            }
            _unitOfWork.Complete();
        }
    }
}