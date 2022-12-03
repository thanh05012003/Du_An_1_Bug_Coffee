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
    public class HoaDonService:IHoaDonService
    {
        private IHoaDonRepository _hoaDonRepository;
        private IKhachHangService _khachHangService;
        private INhanVienService _nhanVienService;
        private IVoucherService _voucherService;
        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _khachHangService =  new KhachHangService();
            _nhanVienService = new NhanVienService();
            _voucherService = new VoucherService();
        }
        public string add(QlHoaDonView obj)
        {
            if (obj == null) return "Thêm không thành công";
            HoaDon hoaDon = new HoaDon()
            {
                Ma = obj.Ma,
                MaKH = obj.MaKH,
                MaNV = obj.MaNV,
                NgayTao = obj.NgayTao,
                MaVC = obj.MaVC
            };
            if (_hoaDonRepository.Add(hoaDon))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlHoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlHoaDonView obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            HoaDon hoaDon = new HoaDon()
            {
                Ma = obj.Ma,
                MaKH = obj.MaKH,
                MaNV = obj.MaNV,
                NgayTao = obj.NgayTao,
                MaVC = obj.MaVC
            };
            if (_hoaDonRepository.Update(hoaDon))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlHoaDonView> GetAll()
        {
            var lstHoaDon = from a in _hoaDonRepository.GetAll()
                join b in _nhanVienService.GetAll() on a.MaNV equals b.Ma
                join c in _khachHangService.GetAll() on a.MaKH equals c.Ma
                join d in _voucherService.GetAll() on a.MaVC equals d.Ma
                select new QlHoaDonView()
                {
                    Ma = a.Ma,
                    MaKH = a.MaKH,
                    MaNV = a.MaNV,
                    NgayTao = a.NgayTao,
                    MaVC = a.MaVC,
                    TenKH = c.Ten,
                    TenNV = b.Ten,
                    TenVoucher = d.Ten
                };
            return lstHoaDon.ToList();
        }
    }
}
