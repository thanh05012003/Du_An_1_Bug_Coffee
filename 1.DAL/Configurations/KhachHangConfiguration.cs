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
    internal class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(c => c.Ma);//set khoá chính
            builder.Property(p => p.Ma).HasColumnType("varchar(20)");
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired(); // IsRequired: bắt buộc
            builder.Property(p => p.DiemTL).HasColumnType("int").IsRequired();
            builder.Property(p => p.SDT).HasColumnType("varchar(30)").IsRequired();
            builder.Property(p => p.MaLKH).IsRequired();

            //set khoá ngoại
            builder.HasOne(c => c.LoaiKhachHang).WithMany().HasForeignKey(c => c.MaLKH);

        }
    }
}
