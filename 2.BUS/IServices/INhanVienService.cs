using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface INhanVienService
    {
        string add(QlNhanVienView obj);
        string delete(QlNhanVienView obj);
        string update(QlNhanVienView obj);
        List<QlNhanVienView> GetAll();
    }
}
