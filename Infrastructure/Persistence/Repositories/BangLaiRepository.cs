using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class BangLaiRepository : Repository<BangLai>, IBangLaiRepository
    {
        public IEnumerable<BangLai> GetViewDSBangLai(string search, string genre)
        {
            var dsbl = from m in HeThongQuanLyVPGTContext.DanhSachBangLai
                       select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "MaBangLai")
                {
                    dsbl = dsbl.Where(m => m.MaBangLai.Contains(search));
                }
            }
            return dsbl.ToList();
        }
        public BangLaiRepository(HeThongQuanLyVPGTContext context) : base(context)
        {
        }

        protected HeThongQuanLyVPGTContext HeThongQuanLyVPGTContext
        {
            get { return Context as HeThongQuanLyVPGTContext; }
        }
    }
}