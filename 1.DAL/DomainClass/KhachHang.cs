using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    public class KhachHang
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int DiemTL { get; set; }
        public string MaLKH { get; set; }
        public virtual LoaiKhachHang? LoaiKhachHang { get; set; }
    }
}
