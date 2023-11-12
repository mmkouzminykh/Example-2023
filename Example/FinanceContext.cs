using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class FinanceContext: DbContext
    {
        public FinanceContext() { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Finance;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Property>()
                .ToTable("Properties")
                .HasKey(p => p.Id);
            modelBuilder.Entity<Property>()
                .Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired();
            modelBuilder.Entity<Property>()
                .Property(p => p.Price)
                .HasPrecision(15, 2)                
                .IsRequired();

            modelBuilder.Entity<Property>()
                .ToTable(t =>t.HasCheckConstraint("CK_Price_GreaterZero", "Price > 0"));

            modelBuilder.Entity<Property>()
                .HasMany(p => p.Operations)
                .WithOne(o => o.Property)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                .HasMany(p => p.RenewalDetails)
                .WithOne(r => r.Property)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PriceRenewal>()
                .HasMany(pr => pr.RenewalDetails)
                .WithOne(d => d.PriceRenewal)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RenewalDetail>()
                .HasKey(new string[] { nameof(RenewalDetail.PropertyId), nameof(RenewalDetail.PriceRenewalId) });

            modelBuilder.ApplyConfiguration(new PurchaseSaleConfiguration());
            
        }

    }
}
