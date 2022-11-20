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
    internal class CaLVConfiguration : IEntityTypeConfiguration<CaLV>

    {
        public void Configure(EntityTypeBuilder<CaLV> builder)
        {
            builder.HasKey(k => k.Ma);
            builder.Property(p => p.Ma).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.ThoiGianBatDau).HasColumnType("date").IsRequired();
            builder.Property(p => p.ThoiGianKetThuc).HasColumnType("date").IsRequired();
            builder.Property(p => p.SoTien).HasColumnType("money").IsRequired();
        }
    }
}
