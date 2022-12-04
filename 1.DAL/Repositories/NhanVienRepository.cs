using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System.Collections.Generic;
using System.Linq;

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

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _DbContext.NhanVien.FirstOrDefault(c => c.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.Email = obj.Email;
            tempobj.SDT = obj.SDT;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.MaCV = obj.MaCV;
            tempobj.TrangThai = obj.TrangThai;
            tempobj.URL = obj.URL;
            _DbContext.Update(tempobj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
