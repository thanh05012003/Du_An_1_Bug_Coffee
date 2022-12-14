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
    public class BanService:IBanService
    {
        private IBanRepository _banRepository;
        private IHoaDonRepository _hoaDonRepository;
        private IHoaDonCTRepository _hoaDonCtRepository;
        private ISanPhamRepository _sanPhamRepository;

        public BanService()
        {
            _banRepository = new BanRepository();
        }
        public string add(QlBanView obj)
        {
            if (obj == null) return "Thêm không thành công";
            Ban ban = new Ban()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_banRepository.Add(ban))
            {
                return "Thêm thành công";
            }

            return "Thêm không thành công";

        }


        public string update(QlBanView obj)
        {
            if (obj == null) return "cập nhật không thành công";
            Ban ban = new Ban()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_banRepository.Update(ban))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật không thành công";
        }

        public List<QlBanView> GetAll()
        {
            var lstBan = from a in _banRepository.GetAll()
                select new QlBanView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TrangThai = a.TrangThai,
                };
            return lstBan.ToList();
        }

        public List<QlBanView> GetAll(string input)
        {
            if (input == null)
            {
                return GetAll();
            }
            var lstBan = from a in _banRepository.GetAll()
                join b in _hoaDonRepository.GetAll() on a.Ma equals b.MaBan
                select new QlBanView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TrangThai = a.TrangThai,
                    MaHD = b.Ma,
                };

            return lstBan.Where(c =>c.Ma == input || c.MaHD == input).ToList();
        }
    }
}
