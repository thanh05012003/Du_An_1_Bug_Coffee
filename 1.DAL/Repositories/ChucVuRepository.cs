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
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDbContext _DbContext;
        public ChucVuRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(ChucVu obj)
        {
            if(obj == null) return false;
            _DbContext.ChucVu.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _DbContext.ChucVu.ToList();
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
