using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

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
            var lstht = _DbContext.HoaDon.ToList();
            return lstht;
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _DbContext.HoaDon.FirstOrDefault(x => x.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.MaKH = obj.MaKH;
            tempobj.MaNV = obj.MaNV;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.MaVC = obj.MaVC;
            tempobj.TrangThai = obj.TrangThai;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.MaBan = obj.MaBan;
            _DbContext.Update(tempobj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
