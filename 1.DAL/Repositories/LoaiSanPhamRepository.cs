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
    public class LoaiSanPhamRepository : ILoaiSanPhamRepository
    {
        private FpolyDbContext _DbContext;
        public LoaiSanPhamRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(LoaiSanPham obj)
        {
            if(obj == null) return false;
            _DbContext.LoaiSanPham.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiSanPham obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<LoaiSanPham> GetAll()
        {
            return _DbContext.LoaiSanPham.ToList();
        }

        public bool Update(LoaiSanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _DbContext.LoaiSanPham.FirstOrDefault(c => c.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _DbContext.Update(tempobj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
