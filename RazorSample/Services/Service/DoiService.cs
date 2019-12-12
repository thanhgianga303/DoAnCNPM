using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class DoiService : IDoiService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public DoiService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DoiVM GetDoiViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSDoi = _unitOfWork.DanhSachDoi.GetViewDSDoi(SearchString, Genre);
            return new DoiVM
            {
                DanhSachDoi = PaginatedList<Doi>.Create(DSDoi, pageIndex, pageSize),
            };
        }

        public void DeleteDoi(int id)
        {
            var Doi = _unitOfWork.DanhSachDoi.GetBy(id);
            if (Doi != null)
            {
                _unitOfWork.DanhSachDoi.Remove(Doi);
                _unitOfWork.Complete();
            }
        }
        public void AddDoi(Doi Doi)
        {
            _unitOfWork.DanhSachDoi.Add(Doi);
            _unitOfWork.Complete();
        }
        public void UpdateDoi(int id, Doi Doi)
        {
            var _Doi = _unitOfWork.DanhSachDoi.GetBy(id);
            if (_Doi != null)
            {
                _Doi.MaDoi = Doi.MaDoi;
                _Doi.TenDoi = Doi.TenDoi;
            }
            _unitOfWork.Complete();
        }
        public Doi GetDoi(int id)
        {
            var _Doi = _unitOfWork.DanhSachDoi.GetBy(id);
            return _Doi;
        }
    }
}