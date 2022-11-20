using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ILoaiSanPhamRepository
    {
        bool Add(LoaiSanPham obj);
        bool Udpate(LoaiSanPham obj);
        bool Delete(LoaiSanPham obj);
        List<LoaiSanPham> GetAll();
    }
}
