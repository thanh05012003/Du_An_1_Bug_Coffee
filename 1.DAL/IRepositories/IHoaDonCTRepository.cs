using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonCTRepository
    {
        bool Add(HoaDonCT obj);
        bool Update(HoaDonCT obj);
        bool Delete(HoaDonCT obj);
        List<HoaDonCT> GetAll();
    }
}
