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
    internal class LoaiKHConfigruration : IEntityTypeConfiguration<LoaiKhachHang>
    {
        public void Configure(EntityTypeBuilder<LoaiKhachHang> builder)
        {
            builder.HasKey(x => x.Ma);
            builder.Property(p => p.Ma).HasColumnType("varchar(20)");
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
