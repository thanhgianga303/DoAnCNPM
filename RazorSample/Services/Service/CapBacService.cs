using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class CapBacService : ICapBacService
    {
        private int pageSize = 5;
        private readonly IUnitOfWork _unitOfWork;

        public CapBacService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public CapBacVM GetCapBacViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSCapBac = _unitOfWork.DanhSachCapBac.GetViewDSCapBac(SearchString, Genre);
            return new CapBacVM
            {
                DanhSachCapBac = PaginatedList<CapBac>.Create(DSCapBac, pageIndex, pageSize),
            };
        }
        public CapBac GetCapBac(int id)
        {
            var _CapBac = _unitOfWork.DanhSachCapBac.GetBy(id);
            return _CapBac;
        }
        public void AddCapBac(CapBac CapBac)
        {
            _unitOfWork.DanhSachCapBac.Add(CapBac);
            _unitOfWork.Complete();
        }
        public void UpdateCapBac(int id, CapBac CapBac)
        {
            var _CapBac = _unitOfWork.DanhSachCapBac.GetBy(id);
            _CapBac.MaCapBac = CapBac.MaCapBac;
            _CapBac.TenCapBac = CapBac.TenCapBac;
            _unitOfWork.Complete();
        }

        public void DeleteCapBac(int id)
        {
            var CapBac = _unitOfWork.DanhSachCapBac.GetBy(id);
            if (CapBac != null)
            {
                _unitOfWork.DanhSachCapBac.Remove(CapBac);
                _unitOfWork.Complete();
            }
        }
    }
}