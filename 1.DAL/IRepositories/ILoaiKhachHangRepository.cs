using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ILoaiKhachHangRepository
    {
        bool Add(LoaiKhachHang obj);
        bool Update(LoaiKhachHang obj);
        bool Delete(LoaiKhachHang obj);
        List<LoaiKhachHang> GetAll();
    }
}
