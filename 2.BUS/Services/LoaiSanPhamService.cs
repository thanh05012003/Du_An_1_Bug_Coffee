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
    public class LoaiSanPhamService:ILoaiSanPhamService
    {
        private ILoaiSanPhamRepository _loaiSanPhamRepository;

        public LoaiSanPhamService()
        {
            _loaiSanPhamRepository = new LoaiSanPhamRepository();
        }
        public string add(QlLoaiSanPhamView obj)
        {
            if (obj == null) return "Thêm không thành công ";
            LoaiSanPham loaiSanPham = new LoaiSanPham()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_loaiSanPhamRepository.Add(loaiSanPham))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlLoaiSanPhamView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlLoaiSanPhamView obj)
        {
            if (obj == null) return "Cập nhật không thành công ";
            LoaiSanPham loaiSanPham = new LoaiSanPham()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_loaiSanPhamRepository.Update(loaiSanPham))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlLoaiSanPhamView> GetAll()
        {
            var lstLoaiSp = from a in _loaiSanPhamRepository.GetAll()
                select new QlLoaiSanPhamView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                };
            return lstLoaiSp.ToList();
        }

        public List<QlLoaiSanPhamView> GetAll(string input)
        {
            if (input == null)
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma == input).ToList();
        }
    }
}
