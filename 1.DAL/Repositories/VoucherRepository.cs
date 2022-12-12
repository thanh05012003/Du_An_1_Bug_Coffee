using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        private FpolyDbContext _DbContext;
        public VoucherRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(Voucher obj)
        {
            if (obj == null) return false;
            _DbContext.Voucher.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(Voucher obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<Voucher> GetAll()
        {
            return _DbContext.Voucher.ToList();
        }

        public bool Update(Voucher obj)
        {
            if (obj == null) return false;
            var tempobj = _DbContext.Voucher.FirstOrDefault(c => c.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.MoTa = obj.MoTa;
           tempobj.NgayBatDau = obj.NgayBatDau;
           tempobj.NgayKetThuc = obj.NgayKetThuc;
           tempobj.GiamGia = obj.GiamGia;
           tempobj.TrangThai = obj.TrangThai;
            _DbContext.Update(tempobj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
