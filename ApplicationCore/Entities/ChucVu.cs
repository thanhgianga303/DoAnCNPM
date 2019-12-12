using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class ChucVu : IAggregateRoot
    {
        public int ChucVuID { get; set; }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }

        public List<CanBo> DanhSachCanBo { get; set; }

    }
}
