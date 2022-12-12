using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IVoucherService
    {
        string add(QlVoucherView obj);
        string delete(QlVoucherView obj);
        string update(QlVoucherView obj);
        List<QlVoucherView> GetAll();
        List<QlVoucherView> GetAll(string input);
    }
}
