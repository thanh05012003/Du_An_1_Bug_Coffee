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
    public class KhachHangService:IKhachHangService
    {
        private IKhachHangRepository _khachHangRepository;

        public KhachHangService()
        {
            _khachHangRepository = new KhachHangRepository();
        }
        public string add(QlKhachHangView obj)
        {
            if (obj == null) return "Thêm không thành công ";
            KhachHang KhachHang = new KhachHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiemTL = obj.DiemTL,
                DiaChi = obj.DiaChi,
            };
            if (_khachHangRepository.Add(KhachHang))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlKhachHangView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlKhachHangView obj)
        {
            if (obj == null) return "Cập nhật không thành công ";
            KhachHang KhachHang = new KhachHang()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiemTL = obj.DiemTL,
                DiaChi = obj.DiaChi,
            };
            if (_khachHangRepository.Update(KhachHang))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlKhachHangView> GetAll()
        {
            var lstKhachHang = from a in _khachHangRepository.GetAll()
                select new QlKhachHangView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                    SDT = a.SDT,
                    NgaySinh = a.NgaySinh,
                    DiemTL = a.DiemTL,
                    DiaChi = a.DiaChi
                };
            return lstKhachHang.ToList();
        }
        public List<QlKhachHangView> GetAll(string sdt)
        {
            var lstKhachHang = from a in _khachHangRepository.GetAll()
                select new QlKhachHangView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                    SDT = a.SDT,
                    NgaySinh = a.NgaySinh,
                    DiemTL = a.DiemTL,
                    DiaChi = a.DiaChi
                };
            return lstKhachHang.Where(c =>c.SDT == sdt).ToList();
        }
    }
}
