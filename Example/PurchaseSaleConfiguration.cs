using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class PurchaseSaleConfiguration : IEntityTypeConfiguration<PurchaseSale>
    {
        public void Configure(EntityTypeBuilder<PurchaseSale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Price)
                .HasPrecision(15, 2)
                .IsRequired();
            builder.Property(p => p.Quantity)
                .IsRequired();
            builder.Property(p => p.Sum)
                .HasPrecision(15, 2)
                .IsRequired();

            builder.HasOne(p => p.Transaction);
                
        }
    }
}
