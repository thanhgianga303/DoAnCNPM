using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
namespace RazorSample.Services.Service
{
    public class CanBoService : ICanBoService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public CanBoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public CanBoVM GetCanBoViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSCanBo = _unitOfWork.DanhSachCanBo.GetViewDSCanBo(SearchString, Genre);
            return new CanBoVM
            {
                DanhSachCanBo = PaginatedList<CanBo>.Create(DSCanBo, pageIndex, pageSize),
            };
        }

        public void DeleteCanBo(int id)
        {
            var CanBo = _unitOfWork.DanhSachCanBo.GetBy(id);
            if (CanBo != null)
            {
                _unitOfWork.DanhSachCanBo.Remove(CanBo);
                _unitOfWork.Complete();
            }
        }
        public void AddCanBo(CanBo CanBo)
        {
            _unitOfWork.DanhSachCanBo.Add(CanBo);
            _unitOfWork.Complete();
        }
        public void UpdateCanBo(int id, CanBo CanBo)
        {
            var _CanBo = _unitOfWork.DanhSachCanBo.GetBy(id);
            _CanBo.MaCanBo = CanBo.MaCanBo;
            _CanBo.Ten = CanBo.Ten;
            _CanBo.TrangThai = CanBo.TrangThai;
            _unitOfWork.Complete();
        }
        public CanBo GetCanBo(int id)
        {
            var CanBo = _unitOfWork.DanhSachCanBo.GetBy(id);
            return CanBo;
        }
    }
}