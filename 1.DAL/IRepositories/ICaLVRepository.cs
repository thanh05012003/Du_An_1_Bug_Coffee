using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICaLVRepository
    {
        bool Add(CaLV obj);
        bool Update(CaLV obj);
        bool Delete(CaLV obj);
        List<CaLV> GetAll();
    }
}
