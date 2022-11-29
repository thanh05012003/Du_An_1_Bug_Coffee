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
    public class HoaDonRepository : IHoaDonRepository
    {
        private FpolyDbContext _DbContext;
        public HoaDonRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(HoaDon obj)
        {
            if(obj == null) return false;
            _DbContext.HoaDon.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _DbContext.HoaDon.ToList();
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
