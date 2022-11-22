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
    public class VoucherService:IVoucherService
    {
        private IVoucherRepository _voucherRepository;

        public VoucherService()
        {
            _voucherRepository = new VoucherRepository();
        }

        public string add(QlVoucherView obj)
        {
            if (obj == null) return "Thêm không thành công";
            Voucher voucher = new Voucher()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                NgayBatDau = obj.NgayBatDau,
                NgayKetThuc = obj.NgayKetThuc,
                TrangThai = obj.TrangThai,
                GiamGia = obj.GiamGia,
                MoTa = obj.MoTa
            };
            if (_voucherRepository.Add(voucher))
            {
                return "Thêm thành công";
            }

            return "Thêm khônng thành công";
        }

        public string delete(QlVoucherView obj)
        {
            throw new NotImplementedException();
        }

        public string update(QlVoucherView obj)
        {
            if (obj == null) return "Cập nhật không thành công";
            Voucher voucher = new Voucher()
            {
                Ma = obj.Ma,
                Ten = obj.Ten,
                NgayBatDau = obj.NgayBatDau,
                NgayKetThuc = obj.NgayKetThuc,
                TrangThai = obj.TrangThai,
                GiamGia = obj.GiamGia,
                MoTa = obj.MoTa
            };
            if (_voucherRepository.Update(voucher))
            {
                return "Cập nhật thành công";
            }

            return "Cập nhật khônng thành công";
        }

        public List<QlVoucherView> GetAll()
        {
            var lstVoucher = from a in _voucherRepository.GetAll()
                select new QlVoucherView()
                {
                    Ma = a.Ma,
                    Ten = a.Ten,
                    NgayBatDau = a.NgayBatDau,
                    NgayKetThuc = a.NgayKetThuc,
                    TrangThai = a.TrangThai,
                    GiamGia = a.GiamGia,
                    MoTa = a.MoTa
                };
            return lstVoucher.ToList();
        }
    }
}
