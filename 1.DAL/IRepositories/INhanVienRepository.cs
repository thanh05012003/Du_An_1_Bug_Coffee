using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    internal interface INhanVienRepository
    {
        bool Add(NhanVien obj);
        bool Udpate(NhanVien obj);
        bool Delete(NhanVien obj);
        List<NhanVien> GetAll();
    }
}
