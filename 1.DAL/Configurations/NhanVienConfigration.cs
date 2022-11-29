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
    internal class NhanVienConfigration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasKey(c => c.Ma);
            builder.Property(c => c.Ma).HasColumnType("varchar(20)").IsRequired();
            builder.Property(c => c.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.GioiTinh).HasColumnType("nvarchar(10)");
            builder.Property(c => c.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(c => c.SDT).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(c => c.Email).HasColumnType("varchar(100)");
            builder.Property(c => c.TrangThai).HasColumnType("int").IsRequired();
            builder.Property(c => c.MatKhau).HasColumnType("varchar(max)").IsRequired();
            builder.Property(c => c.MaCV);
            builder.HasOne(c => c.ChucVu).WithMany().HasForeignKey(c => c.MaCV);
            builder.Property(c => c.MaCLV);
            builder.HasOne(c => c.CaLv).WithMany().HasForeignKey(c => c.MaCLV);
        }
    }
}
