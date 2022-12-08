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
    internal class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(c => c.Ma);
            builder.Property(c => c.Ma).HasColumnType("varchar(20)");
            builder.Property(c => c.MaKH);
            builder.Property(c => c.MaNV);
            builder.Property(c => c.NgayTao).HasColumnType("datetime");
            builder.Property(c => c.TrangThai).HasColumnType("nvarchar(100)");
            builder.Property(c => c.GhiChu).HasColumnType("nvarchar(100)");
            builder.Property(c => c.MaBan);
            //Khoá ngoại
            builder.HasOne(c => c.KhachHang).WithMany().HasForeignKey(c => c.MaKH);
            builder.HasOne(c => c.NhanVien).WithMany().HasForeignKey(c => c.MaNV);
            builder.HasOne(c => c.Voucher).WithMany().HasForeignKey(c => c.MaVC);
            builder.HasOne(c => c.Ban).WithMany().HasForeignKey(c => c.MaBan);
        }
    }
}
