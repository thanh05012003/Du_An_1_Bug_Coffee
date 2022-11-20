using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class BanRepository : IBanRepository
    {
        private FpolyDbContext _DbContext;
        public BanRepository()
        {
            _DbContext = new FpolyDbContext();
        }
        public bool Add(Ban obj)
        {
            if(obj == null) return false;
            _DbContext.Ban.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(Ban obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<Ban> GetAll()
        {
            return _DbContext.Ban.ToList();
        }

        public bool Udpate(Ban obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
