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
    public class CaLVRepository : ICaLVRepository
    {
        private FpolyDbContext _DbContext;
        public CaLVRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(CaLV obj)
        {
            if(obj == null) return false;
            _DbContext.CaLv.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(CaLV obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<CaLV> GetAll()
        {
            return _DbContext.CaLv.ToList();
        }

        public bool Update(CaLV obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
