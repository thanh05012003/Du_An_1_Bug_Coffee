using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    public class NhanVien
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int TrangThai { get; set; }
        public string MatKhau { get; set; }
        public string MaCV { get; set; }
        public string MaCLV { get; set; }
        public string URL { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual CaLV CaLv { get; set; }
    }
}
