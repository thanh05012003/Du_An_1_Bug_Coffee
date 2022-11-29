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
    public class SanPhamService:ISanPhamService
    {
        private ISanPhamRepository _sanPhamRepository;

        public SanPhamService()
        {
            _sanPhamRepository = new SanPhamRepository();
        }

        public string add(QlSanPhamView obj)
        {
            if (obj == null) return "Thêm không thành công";
            SanPham SanPham = new SanPham()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
                Gia = obj.Gia,
                MoTa = obj.MoTa,
                URL = obj.URl,
                MaLsp = obj.MaLsp,
            };
            if (_sanPhamRepository.Add(SanPham))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlSanPhamView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlSanPhamView obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            SanPham SanPham = new SanPham()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
                Gia = obj.Gia,
                MoTa = obj.MoTa,
                URL = obj.URl,
                MaLsp = obj.MaLsp,
            };
            if (_sanPhamRepository.Update(SanPham))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlSanPhamView> GetAll()
        {
            var lstSanPham = from a in _sanPhamRepository.GetAll()
                select new QlSanPhamView
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TrangThai = a.TrangThai,
                    Gia = a.Gia,
                    MoTa = a.MoTa,
                    MaLsp = a.MaLsp,
                    URl = a.URL,
                };
            return lstSanPham.ToList();
        }
    }
}
