using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IVoucherRepository
    {
        bool Add(Voucher obj);
        bool Udpate(Voucher obj);
        bool Delete(Voucher obj);
        List<Voucher> GetAll();
    }
}
