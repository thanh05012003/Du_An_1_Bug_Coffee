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


        public List<Ban> GetAll()
        {
            return _DbContext.Ban.ToList();
        }

        public bool Update(Ban obj)
        {
            if (obj == null) return false;
            var temp = _DbContext.Ban.FirstOrDefault(c =>c.Ma == obj.Ma);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.TrangThai = obj.TrangThai;
            _DbContext.Ban.Update(temp);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
