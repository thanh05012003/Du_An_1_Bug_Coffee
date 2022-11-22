using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IChucVuService
    {
        string add(QlChucVuView obj);
        string delete(QlChucVuView obj);
        string update(QlChucVuView obj);
        List<QlChucVuView> GetAll();
    }
}
