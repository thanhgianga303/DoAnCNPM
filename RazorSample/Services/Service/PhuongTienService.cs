using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;

namespace RazorSample.Services.Service
{
    public class PhuongTienService : IPhuongTienService
    {
        private readonly IUnitOfWork _unitOfWork;
        private int pageSize = 3;
        public PhuongTienService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PhuongTienVM GetPhuongTienViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSPhuongTien = _unitOfWork.DanhSachPhuongTien.GetViewDSPhuongTien(SearchString, Genre);
            return new PhuongTienVM
            {
                DanhSachPhuongTien = PaginatedList<PhuongTien>.Create(DSPhuongTien, pageIndex, pageSize),
            };
        }
        public void AddPhuongTien(PhuongTien PhuongTien)
        {
            _unitOfWork.DanhSachPhuongTien.Add(PhuongTien);
            _unitOfWork.Complete();
        }
        public void DeletePhuongTien(int id)
        {
            var _PhuongTien = _unitOfWork.DanhSachPhuongTien.GetBy(id);
            if (_PhuongTien != null)
            {
                _unitOfWork.DanhSachPhuongTien.Remove(_PhuongTien);
                _unitOfWork.Complete();
            }
        }
        public void UpdatePhuongTien(int id, PhuongTien PhuongTien)
        {
            var _PhuongTien = _unitOfWork.DanhSachPhuongTien.GetBy(id);
            if (_PhuongTien != null)
            {
                _PhuongTien.CaVet = PhuongTien.CaVet;
                _PhuongTien.BKS = PhuongTien.BKS;
            }
            _unitOfWork.Complete();
        }
        public PhuongTien GetPhuongTien(int id)
        {
            var _PhuongTien = _unitOfWork.DanhSachPhuongTien.GetBy(id);
            return _PhuongTien;
        }
    }
}