using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        string add(QlHoaDonView obj);
        string delete(QlHoaDonView obj);
        string update(QlHoaDonView obj);
        List<QlHoaDonView> GetAll();
    }
}
