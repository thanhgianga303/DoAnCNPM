using System.Collections.Generic;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class CapBac : IAggregateRoot
    {
        public int CapBacID { get; set; }
        public string MaCapBac { get; set; }
        public string TenCapBac { get; set; }

        public List<CanBo> DanhSachCanBo { get; set; }

    }
}