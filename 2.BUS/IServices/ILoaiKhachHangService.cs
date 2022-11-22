using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface ILoaiKhachHangService
    {
        string add(QlLoaiKhachHangView obj);
        string delete(QlLoaiKhachHangView obj);
        string update(QlLoaiKhachHangView obj);
        List<QlLoaiKhachHangView> GetAll();
    }
}
