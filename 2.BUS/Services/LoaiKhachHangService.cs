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
    public class LoaiKhachHangService:ILoaiKhachHangService
    {
        private ILoaiKhachHangRepository _loaiKhachHangRepository;

        public LoaiKhachHangService()
        {
            _loaiKhachHangRepository = new LoaiKhachHangRepository();
        }
        public string add(QlLoaiKhachHangView obj)
        {
            if (obj == null) return "Thêm không thành công ";
            LoaiKhachHang LoaiKhachHang = new LoaiKhachHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_loaiKhachHangRepository.Add(LoaiKhachHang))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlLoaiKhachHangView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlLoaiKhachHangView obj)
        {
            if (obj == null) return "Cập nhật không thành công ";
            LoaiKhachHang LoaiKhachHang = new LoaiKhachHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_loaiKhachHangRepository.Update(LoaiKhachHang))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlLoaiKhachHangView> GetAll()
        {
            var lstLoaiKhachHang = from a in _loaiKhachHangRepository.GetAll()
                select new QlLoaiKhachHangView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten
                };
            return lstLoaiKhachHang.ToList();
        }
    }
}
