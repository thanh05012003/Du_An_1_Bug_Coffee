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
    public class NhanVienService:INhanVienService
    {
        private INhanVienRepository _nhanVienRepository;
        private IChucVuRepository _chucVuRepository;

        public NhanVienService()
        {
            _nhanVienRepository = new NhanVienRepository();
            _chucVuRepository = new ChucVuRepository();
        }
        public string add(QlNhanVienView obj)
        {
            if (obj == null) return "Thêm không thành công";
            NhanVien NhanVien = new NhanVien()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                MaCV = obj.MaCV,
                MaCLV = obj.MaCLV,
                URL = obj.URL
            };
            if (_nhanVienRepository.Add(NhanVien))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlNhanVienView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlNhanVienView obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            NhanVien NhanVien = new NhanVien()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                MaCV = obj.MaCV,
                MaCLV = obj.MaCLV,
                URL = obj.URL
            };
            if (_nhanVienRepository.Update(NhanVien))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlNhanVienView> GetAll()
        {
            var lstNhanVien = from a in _nhanVienRepository.GetAll()
                join b in _chucVuRepository.GetAll() on a.MaCV equals b.Ma 
                select new QlNhanVienView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                    GioiTinh = a.GioiTinh,
                    NgaySinh = a.NgaySinh,
                    DiaChi = a.DiaChi,
                    SDT = a.SDT,
                    Email = a.Email,
                    TrangThai = a.TrangThai,
                    MatKhau = a.MatKhau,
                    MaCV = a.MaCV,
                    MaCLV = a.MaCLV,
                    TenCv = b.Ten,
                    URL = a.URL,
                };
            return lstNhanVien.ToList();
        }
    }
}
