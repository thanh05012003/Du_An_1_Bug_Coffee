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
    public class ChucVuService:IChucVuService
    {
        IChucVuRepository _chucVuRepository;

        public ChucVuService()
        {
            _chucVuRepository = new ChucVuRepository();
        }
        public string add(QlChucVuView obj)
        {
            if (obj == null) return "Thêm không thành công";
            ChucVu cv = new ChucVu()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_chucVuRepository.Add(cv))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlChucVuView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlChucVuView obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            ChucVu cv = new ChucVu()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_chucVuRepository.Update(cv))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlChucVuView> GetAll()
        {
            var lstChucVu = from a in _chucVuRepository.GetAll()
                select new QlChucVuView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten
                };
            return lstChucVu.ToList();
        }
    }
}
