using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    public class HoaDon
    {
        public string Ma { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MaVC { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string MaBan { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual Ban Ban { get; set; }
    }
}
