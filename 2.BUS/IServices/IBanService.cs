using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IBanService
    {
        string add(QlBanView obj);
        string update(QlBanView obj);
        List<QlBanView> GetAll();
    }
}
