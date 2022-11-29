using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface ICaLVService
    {
        string add(QlCaLVView obj);
        string delete(QlCaLVView obj);
        string update(QlCaLVView obj);
        List<QlCaLVView> GetAll();
    }
}
