using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface ISanPhamService
    {
        string add(QlSanPhamView obj);
        string delete(QlSanPhamView obj);
        string update(QlSanPhamView obj);
        List<QlSanPhamView> GetAll();
        List<QlSanPhamView> GetAll(string ma);
    }
}
