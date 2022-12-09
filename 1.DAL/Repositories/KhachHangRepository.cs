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
    public class KhachHangRepository : IKhachHangRepository
    {
        private FpolyDbContext _DbContext;
        public KhachHangRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(KhachHang obj)
        {
            if(obj == null) return false;
            _DbContext.KhachHang.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _DbContext.KhachHang.ToList();
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var temp = _DbContext.KhachHang.FirstOrDefault(c =>c.Ma == obj.Ma);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.DiaChi = obj.DiaChi;
            temp.DiemTL = obj.DiemTL;
            temp.NgaySinh = obj.NgaySinh;
            temp.SDT = obj.SDT;
            _DbContext.Update(temp);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
