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
    internal class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(k => k.Ma);
            builder.Property(p => p.Ma).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
            builder.Property(p => p.Gia).HasColumnType("money").IsRequired();
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(100)");
            builder.Property(p => p.MaLsp);
            builder.Property(p => p.URL).HasColumnType("nvarchar(max)");
            builder.HasOne(c => c.LoaiSanPham).WithMany().HasForeignKey(c => c.MaLsp);
        }
    }
}
