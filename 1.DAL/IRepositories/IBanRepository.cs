using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IBanRepository
    {
        bool add(Ban obj);
        bool delete(Ban obj);
        bool udpate(Ban obj);
        List<Ban> GetAll();
    }
}
