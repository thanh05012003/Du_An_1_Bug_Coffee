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
    public class NhanVienRepository : INhanVienRepository
    {
        private FpolyDbContext _DbContext;
        public NhanVienRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.NhanVien.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _DbContext.NhanVien.ToList();
        }

        public bool Udpate(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
