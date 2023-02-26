using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntityConfigurations
{
    public class SalesOrderConfiguration : IEntityTypeConfiguration<SalesOrderHeader>, IEntityTypeConfiguration<SalesOrderDetail>
    {
        public void Configure(EntityTypeBuilder<SalesOrderHeader> builder)
        {
            builder.ToTable("SalesOrderHeader");
            builder.HasIndex(q => q.OrderNumber).IsUnique();
            builder.Navigation(q => q.SalesOrderDetails).AutoInclude();
        }

        public void Configure(EntityTypeBuilder<SalesOrderDetail> builder)
        {
            builder.ToTable("SalesOrderDetail");
            builder.HasOne(q => q.Product).WithMany(q => q.SalesOrderDetails).OnDelete(DeleteBehavior.NoAction);
            builder.Navigation(q => q.OrderHeader).AutoInclude();
        }
    }
}
