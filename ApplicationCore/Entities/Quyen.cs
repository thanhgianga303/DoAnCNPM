using System.Collections.Generic;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Quyen : IAggregateRoot
    {
        public int QuyenID { get; set; }
        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string MoTaQuyen { get; set; }
        public List<TaiKhoan> DanhSachTaiKhoan { get; set; }
    }
}