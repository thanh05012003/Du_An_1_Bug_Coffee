using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        string add(QlKhachHangView obj);
        string delete(QlKhachHangView obj);
        string update(QlKhachHangView obj);
        List<QlKhachHangView> GetAll();
        List<QlKhachHangView> GetAll(string sdt);
    }
}
