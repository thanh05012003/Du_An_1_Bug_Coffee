﻿using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private FpolyDbContext _DbContext;
        public SanPhamRepository()
        {
            _DbContext = new FpolyDbContext();
        }

        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            _DbContext.SanPham.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _DbContext.SanPham.ToList();
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _DbContext.SanPham.FirstOrDefault(c => c.Ma == obj.Ma);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.Gia = obj.Gia;
            tempobj.MoTa = obj.MoTa;
            tempobj.MaLsp = obj.MaLsp;
            tempobj.URL = obj.URL;
            tempobj.TrangThai = obj.TrangThai;
            _DbContext.Update(tempobj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
