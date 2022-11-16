using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    public class Voucher
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int TrangThai { get; set; }
        public int GiamGia { get; set; }
        public string MoTa { get; set; }
    }
}
