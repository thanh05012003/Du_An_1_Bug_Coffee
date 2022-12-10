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

        private INhanVienRepository _nhanVienRepository;
        private IKhachHangRepository _khachHangRepository;
        private ISanPhamRepository _sanPhamRepository;
        private IHoaDonCTRepository _hoaDonCtRepository;
        private IBanRepository _banRepository;
        IVoucherRepository _voucherRepository;
        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _nhanVienRepository = new NhanVienRepository();
            _sanPhamRepository = new SanPhamRepository();
            _hoaDonCtRepository = new HoaDonCTRepository();
            _banRepository = new BanRepository();
            _khachHangRepository = new KhachHangRepository();
            _voucherRepository = new VoucherRepository();
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
                MaVC = obj.MaVC,
                TrangThai = obj.TrangThai,
                MaBan = obj.MaBan,
                GhiChu = obj.GhiChu,
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
                MaVC = obj.MaVC,
                TrangThai = obj.TrangThai,
                MaBan = obj.MaBan,
                GhiChu = obj.GhiChu
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
                join b in _nhanVienRepository.GetAll() on a.MaNV equals b.Ma
                select new QlHoaDonView()
                {
                    Ma = a.Ma,
                    MaKH = a.MaKH,
                    MaNV = a.MaNV,
                    NgayTao = a.NgayTao,
                    MaVC = a.MaVC,
                    TenNV = b.Ten,
                    GhiChu = a.GhiChu,
                    TrangThai = a.TrangThai,
                    MaBan = a.MaBan,
                };
            return lstHoaDon.ToList();
        }

        public List<QlHoaDonView> GetAll(string input)
        {
            if (input == null)
            {
                return GetAll();
            }

            var lstHoaDon = from a in _hoaDonRepository.GetAll().Where(c => c.MaBan == input || c.Ma == input)
                join b in _nhanVienRepository.GetAll() on a.MaNV equals b.Ma
                join d in _hoaDonCtRepository.GetAll() on a.Ma equals d.MaHD
                join e in _sanPhamRepository.GetAll() on d.MaSP equals e.Ma
                join g in _banRepository.GetAll() on a.MaBan equals g.Ma
                select new QlHoaDonView()
                {
                    Ma = a.Ma,
                    MaKH = a.MaKH,
                    MaNV = a.MaNV,
                    NgayTao = a.NgayTao,
                    MaVC = a.MaVC,
                    TenNV = b.Ten,
                    GhiChu = a.GhiChu,
                    TrangThai = a.TrangThai,
                    TenSP = e.Ten,
                    Soluong = d.SoLuong,
                    MaBan = g.Ma,
                    DonGia = d.DonGia,
                    TenBan = g.Ten,
                };
            return lstHoaDon.ToList();  
        }

        public List<QlHoaDonView> Lshd()
        {
            var lstHoaDon = from a in _hoaDonRepository.GetAll()
                //join b in _khachHangRepository.GetAll() on a.MaKH equals b.Ma
                join c in _nhanVienRepository.GetAll() on a.MaNV equals c.Ma
                            join d in _voucherRepository.GetAll() on a.MaVC equals d.Ma
                            //join e in _banRepository.GetAll() on a.MaBan equals e.Ma
                select new QlHoaDonView()
                {
                    Ma = a.Ma,
                    //TenKH = b.Ten,
                    TenNV = c.Ten,
                    NgayTao = a.NgayTao,
                    TenVouCher = d.Ten,
                    GhiChu = a.GhiChu,  
                    TrangThai = a.TrangThai,
                    //TenBan = e.Ten,
                };
            return lstHoaDon.ToList();
        }
    }
}
