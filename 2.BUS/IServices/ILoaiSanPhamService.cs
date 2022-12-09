using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface ILoaiSanPhamService
    {
        string add(QlLoaiSanPhamView obj);
        string delete(QlLoaiSanPhamView obj);
        string update(QlLoaiSanPhamView obj);
        List<QlLoaiSanPhamView> GetAll();
        List<QlLoaiSanPhamView> GetAll(string input);
    }
}
