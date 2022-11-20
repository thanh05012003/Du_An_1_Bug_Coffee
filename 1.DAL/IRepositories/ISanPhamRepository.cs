using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        bool Add(SanPham obj);
        bool Udpate(SanPham obj);
        bool Delete(SanPham obj);
        List<SanPham> GetAll();
    }
}
