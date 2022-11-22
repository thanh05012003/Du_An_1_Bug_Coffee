using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class CaLVService:ICaLVService
    {
        private ICaLVRepository _caLvRepository;

        public CaLVService()
        {
            _caLvRepository = new CaLVRepository();
        }
        public string add(QlCaLVView obj)
        {
            if (obj == null) return "Thêm không thành công";
            CaLV caLv = new CaLV()
            {
                Ma = obj.Ma,
                SoTien = obj.SoTien,
                Ten = obj.Ten,
                ThoiGianBatDau = obj.ThoiGianBatDau,
                ThoiGianKetThuc = obj.ThoiGianKetThuc,
            };
            if (_caLvRepository.Add(caLv))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlCaLVView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlCaLVView obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            CaLV caLv = new CaLV()
            {
                Ma = obj.Ma,
                SoTien = obj.SoTien,
                Ten = obj.Ten,
                ThoiGianBatDau = obj.ThoiGianBatDau,
                ThoiGianKetThuc = obj.ThoiGianKetThuc,
            };
            if (_caLvRepository.Update(caLv))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlCaLVView> GetAll()
        {
            var lstCaLV = from a in _caLvRepository.GetAll()
                select new QlCaLVView()
                {
                    Ma = a.Ma,
                    SoTien = a.SoTien,
                    Ten = a.Ten,
                    ThoiGianBatDau = a.ThoiGianBatDau,
                    ThoiGianKetThuc = a.ThoiGianKetThuc
                };
            return lstCaLV.ToList();
        }
    }
}
