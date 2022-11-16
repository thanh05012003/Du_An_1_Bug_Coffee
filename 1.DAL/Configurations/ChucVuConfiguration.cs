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
    internal class ChucVuConfiguration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.HasKey(k => k.Ma);
            builder.Property(p => p.Ma).HasColumnType("varchar(20)");
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
