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
    internal class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(k => k.Ma);
            builder.Property(p => p.Ma).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Ten).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.NgayBatDau).HasColumnType("date").IsRequired();
            builder.Property(p => p.NgayKetThuc).HasColumnType("date").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
            builder.Property(p => p.GiamGia).HasColumnType("int").IsRequired();
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(100)");
        }
    }
}
