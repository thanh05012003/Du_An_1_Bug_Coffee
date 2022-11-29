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
    public class HoaDonCTRepository : IHoaDonCTRepository
    {
        private FpolyDbContext _DbContext;
        public HoaDonCTRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(HoaDonCT obj)
        {
            if(obj == null) return false;
            _DbContext.HoaDonCT.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonCT obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<HoaDonCT> GetAll()
        {
            return _DbContext.HoaDonCT.ToList();
        }

        public bool Update(HoaDonCT obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
