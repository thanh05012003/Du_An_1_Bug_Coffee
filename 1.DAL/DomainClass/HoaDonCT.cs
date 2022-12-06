using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    public class HoaDonCT
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string TrangThai { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
