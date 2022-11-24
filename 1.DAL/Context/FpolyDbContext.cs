using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Context
{
    public class FpolyDbContext:DbContext
    {
        public FpolyDbContext()
        {
            
        }

        public FpolyDbContext(DbContextOptions options) : base(options)
        {
        }

        //Ghi đè phương thức của lớp cha

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Nơi cấu hình đường dẫn
            optionsBuilder.UseSqlServer(
<<<<<<< HEAD

                @"Data Source=MSI;Initial Catalog=Bug_Coffee;Persist Security Info=True;User ID=thanhnxph20424;Password=05012003");

=======
                @"Data Source=DESKTOP-C378UQD\SQLEXPRESS;Initial Catalog=Bug_Coffee;Persist Security Info=True;User ID=tainq27 ;Password=123456");
>>>>>>> 4f5e87bad4aa1020790f92acfa4aaea4ec3442c1
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //phương thức này áp dụng cho các config hiện có
        }

        public DbSet<Ban> Ban { get; set; }
        public DbSet<CaLV> CaLv { get; set; }
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonCT> HoaDonCT { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LoaiKhachHang> LoaiKhachHang { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<Voucher> Voucher { get; set; }
    }
}
