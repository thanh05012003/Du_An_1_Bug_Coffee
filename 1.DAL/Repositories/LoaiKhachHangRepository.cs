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
    public class LoaiKhachHangRepository : ILoaiKhachHangRepository
    {
        private FpolyDbContext _DbContext;
        public LoaiKhachHangRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(LoaiKhachHang obj)
        {
            if(obj == null) return false;
            _DbContext.LoaiKhachHang.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiKhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<LoaiKhachHang> GetAll()
        {
            return _DbContext.LoaiKhachHang.ToList();
        }

        public bool Update(LoaiKhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
