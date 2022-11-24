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
    internal class BanConfiguration : IEntityTypeConfiguration<Ban>
    {
        public void Configure(EntityTypeBuilder<Ban> builder)
        {
            builder.HasKey(c => c.Ma);
            builder.Property(c => c.Ma).HasColumnType("varchar(20)");
            builder.Property(c => c.Ten).HasColumnType("nvarchar(100)");
            builder.Property(c => c.TrangThai).HasColumnType("int");
        }
    }
}
