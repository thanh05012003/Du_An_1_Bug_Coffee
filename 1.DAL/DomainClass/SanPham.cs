using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    public class SanPham
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public decimal Gia { get; set; }
        public string MoTa { get; set; }
        public string MaLsp { get; set; }
        public string URL { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
