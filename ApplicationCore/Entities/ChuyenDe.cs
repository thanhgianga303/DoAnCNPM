using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class ChuyenDe : IAggregateRoot
    {
        public int ChuyenDeID { get; set; }
        public string MaChuyenDe { get; set; }
        public string KhuVuc { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int TrangThai { get; set; }
        public List<Doi> DanhSachDoi { get; set; }
    }
}
