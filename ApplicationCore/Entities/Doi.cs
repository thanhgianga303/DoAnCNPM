using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Doi : IAggregateRoot
    {
        public int DoiID { get; set; }
        public int ChuyenDeID { get; set; }
        public string MaDoi { get; set; }
        public string TenDoi { get; set; }
        public ChuyenDe ChuyenDe { get; set; }
        public List<CanBo> DanhSachCanBo { get; set; }
    }
}
