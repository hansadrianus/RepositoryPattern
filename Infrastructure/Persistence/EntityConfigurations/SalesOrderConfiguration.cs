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
        }

        public void Configure(EntityTypeBuilder<SalesOrderDetail> builder)
        {
            builder.ToTable("SalesOrderDetail");
        }
    }
}
