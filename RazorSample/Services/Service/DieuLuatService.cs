using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class DieuLuatService : IDieuLuatService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public DieuLuatService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DieuLuatVM GetDieuLuatViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSDieuLuat = _unitOfWork.DanhSachDieuLuat.GetViewDSDieuLuat(SearchString, Genre);
            return new DieuLuatVM
            {
                DanhSachDieuLuat = PaginatedList<DieuLuat>.Create(DSDieuLuat, pageIndex, pageSize),
            };
        }

        public void DeleteDieuLuat(int id)
        {
            var DieuLuat = _unitOfWork.DanhSachDieuLuat.GetBy(id);
            if (DieuLuat != null)
            {
                _unitOfWork.DanhSachDieuLuat.Remove(DieuLuat);
                _unitOfWork.Complete();
            }
        }
        public void AddDieuLuat(DieuLuat DieuLuat)
        {
            _unitOfWork.DanhSachDieuLuat.Add(DieuLuat);
            _unitOfWork.Complete();
        }
        public void UpdateDieuLuat(int id, DieuLuat DieuLuat)
        {
            var _DieuLuat = _unitOfWork.DanhSachDieuLuat.GetBy(id);
            if (_DieuLuat != null)
            {
                _DieuLuat.MaDieuLuat = DieuLuat.MaDieuLuat;
                _DieuLuat.Ten = DieuLuat.Ten;
                _DieuLuat.TienPhat = DieuLuat.TienPhat;
            }
            _unitOfWork.Complete();
        }
        public DieuLuat GetDieuLuat(int id)
        {
            var _DieuLuat = _unitOfWork.DanhSachDieuLuat.GetBy(id);
            return _DieuLuat;
        }
    }
}