using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class HoaDonCTService:IHoaDonCTService
    {
        private HoaDonCTRepository _hoaDonCTRepository;

        public HoaDonCTService()
        {
            _hoaDonCTRepository = new HoaDonCTRepository();
        }

        public string add(QlHoaDonCTView obj)
        {
            if (obj == null) return "Thêm không thành công";
            HoaDonCT hdct = new HoaDonCT()
            {
                MaHD = obj.MaHD,
                MaSP = obj.MaSP,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,
                MaBan = obj.MaBan
            };
            if (_hoaDonCTRepository.Add(hdct))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";
        }

        public string delete(QlHoaDonCTView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlHoaDonCTView obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            HoaDonCT hdct = new HoaDonCT()
            {
                MaHD = obj.MaHD,
                MaSP = obj.MaSP,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,
                MaBan = obj.MaBan
            };
            if (_hoaDonCTRepository.Update(hdct))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlHoaDonCTView> GetAll()
        {
            var lstHoaDonCT = from a in _hoaDonCTRepository.GetAll()
                select new QlHoaDonCTView()
                {
                    MaHD = a.MaHD,
                    MaSP = a.MaSP,
                    SoLuong = a.SoLuong,
                    DonGia = a.DonGia,
                    MaBan = a.MaBan
                };
            return lstHoaDonCT.ToList();
        }
    }
}
