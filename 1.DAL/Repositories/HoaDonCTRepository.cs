using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                _DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool Delete(HoaDonCT obj)
        {
            if (obj == null) return false;
            var temp = _DbContext.HoaDonCT.FirstOrDefault(x => x.MaHD == obj.MaHD);
            _DbContext.HoaDonCT.Remove(temp);
            _DbContext.SaveChanges();
            return true;
        }

        public List<HoaDonCT> GetAll()
        {
            var lstHdct = _DbContext.HoaDonCT.ToList();
            return lstHdct;
        }

        public bool Update(HoaDonCT obj)
        {
            if (obj == null) return false;
            var tempb = _DbContext.HoaDonCT.FirstOrDefault(x => x.MaHD == obj.MaHD && x.MaSP == obj.MaSP);
            tempb.MaHD = obj.MaHD;
            tempb.MaSP = obj.MaSP;
            tempb.SoLuong = obj.SoLuong; 
            tempb.DonGia = obj.DonGia;
            tempb.TrangThai = obj.TrangThai;
            _DbContext.HoaDonCT.Update(tempb);
            try
            {
                _DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
