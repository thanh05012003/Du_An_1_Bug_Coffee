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
            if (_banRepository.Add(ban))
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
                    TrangThai = a.TrangThai
                };
            return lstBan.ToList();
        }
    }
}
