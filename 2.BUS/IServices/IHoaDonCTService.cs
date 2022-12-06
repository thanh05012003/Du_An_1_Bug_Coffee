using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IHoaDonCTService
    {
        string add(QlHoaDonCTView obj);
        string delete(QlHoaDonCTView obj);
        string update(QlHoaDonCTView obj);
        List<QlHoaDonCTView> GetAll();
        List<QlHoaDonCTView> GetAll(string input);
    }
}
