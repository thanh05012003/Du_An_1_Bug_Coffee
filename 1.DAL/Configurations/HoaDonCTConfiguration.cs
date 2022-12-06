using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class HoaDonCTConfiguration : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.HasKey(c => new { c.MaSP, c.MaHD });
            builder.Property(c => c.MaHD);
            builder.Property(c => c.MaSP);
            builder.Property(c => c.SoLuong).HasColumnType("int");
            builder.Property(c => c.DonGia).HasColumnType("money");
            builder.Property(c => c.TrangThai).HasColumnType("nvarchar(100)");
            //tạo khoá ngoại
            builder.HasOne(c => c.HoaDon).WithMany().HasForeignKey(c => c.MaHD);
            builder.HasOne(c => c.SanPham).WithMany().HasForeignKey(c => c.MaSP);
           
        }
    }
}
