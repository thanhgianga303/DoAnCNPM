using System.Collections.Generic;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class KhuVuc : IAggregateRoot
    {
        public int KhuVucID { get; set; }
        public string MaKhuVuc { get; set; }
        public string TenKhuVuc { get; set; }
        public List<TuyenDuong> DanhSachTuyenDuong { get; set; }
    }
}