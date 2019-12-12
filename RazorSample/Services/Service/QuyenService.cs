using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;
using System.Collections.Generic;
namespace RazorSample.Services.Service
{
    public class QuyenService : IQuyenService
    {
        private int pageSize = 4;
        private readonly IUnitOfWork _unitOfWork;

        public QuyenService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public QuyenVM GetQuyenViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSQuyen = _unitOfWork.DanhSachQuyen.GetViewDSQuyen(SearchString, Genre);
            // var DSQuyenSelect=_unitOfWork.DanhSachQuyen.GetAll().ToList();
            return new QuyenVM
            {
                DanhSachQuyen = PaginatedList<Quyen>.Create(DSQuyen, pageIndex, pageSize),
                // DSQuyen=DSQuyenSelect
            };
        }
        

        
        public Quyen GetQuyen(int id)
        {
            var _Quyen = _unitOfWork.DanhSachQuyen.GetBy(id);
            return _Quyen;
        }
        public void AddQuyen(Quyen Quyen)
        {
            _unitOfWork.DanhSachQuyen.Add(Quyen);
            _unitOfWork.Complete();
        }
        public void UpdateQuyen(int id, Quyen Quyen)
        {
            var _Quyen = _unitOfWork.DanhSachQuyen.GetBy(id);
            if (_Quyen != null)
            {
                _Quyen.MaQuyen = Quyen.MaQuyen;
                _Quyen.TenQuyen = Quyen.TenQuyen;
                _Quyen.MoTaQuyen = Quyen.MoTaQuyen;
                _unitOfWork.Complete();
            }
        }
        public void DeleteQuyen(int id)
        {
            var _Quyen = _unitOfWork.DanhSachQuyen.GetBy(id);
            if (_Quyen != null)
            {
                _unitOfWork.DanhSachQuyen.Remove(_Quyen);
                _unitOfWork.Complete();
            }
            _unitOfWork.Complete();
        }
    }
}