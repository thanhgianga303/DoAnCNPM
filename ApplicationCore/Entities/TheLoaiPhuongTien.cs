using System.Collections.Generic;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class TheLoaiPhuongTien : IAggregateRoot
    {
        public int TheLoaiPhuongTienID { get; set; }
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public List<PhuongTien> DanhSachPhuongTien { get; set; }
    }
}