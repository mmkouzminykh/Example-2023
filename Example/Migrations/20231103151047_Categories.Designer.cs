﻿// <auto-generated />
using System;
using Example;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Example.Migrations
{
    [DbContext(typeof(FinanceContext))]
    [Migration("20231103151047_Categories")]
    partial class Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryTransaction", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<Guid>("TransactionsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoriesId", "TransactionsId");

                    b.HasIndex("TransactionsId");

                    b.ToTable("CategoryTransaction");
                });

            modelBuilder.Entity("Example.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Example.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Example.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("Example.Source", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Source");
                });

            modelBuilder.Entity("Example.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Sum")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Transactions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Transaction");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Example.TransactionElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TransactionElementId")
                        .HasColumnType("int");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TransactionElementId");

                    b.HasIndex("TransactionId");

                    b.ToTable("TransactionElement");
                });

            modelBuilder.Entity("Example.Expense", b =>
                {
                    b.HasBaseType("Example.Transaction");

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int?>("SourceAccountId")
                        .HasColumnType("int");

                    b.HasIndex("DestinationId");

                    b.HasIndex("SourceAccountId");

                    b.HasDiscriminator().HasValue("Expense");
                });

            modelBuilder.Entity("Example.Income", b =>
                {
                    b.HasBaseType("Example.Transaction");

                    b.Property<int?>("DestinationAccountId")
                        .HasColumnType("int");

                    b.Property<int?>("SourceId")
                        .HasColumnType("int");

                    b.HasIndex("DestinationAccountId");

                    b.HasIndex("SourceId");

                    b.HasDiscriminator().HasValue("Income");
                });

            modelBuilder.Entity("Example.Transfer", b =>
                {
                    b.HasBaseType("Example.Transaction");

                    b.Property<int>("DestinationAccountId")
                        .HasColumnType("int");

                    b.Property<int>("SourceAccountId")
                        .HasColumnType("int");

                    b.HasIndex("DestinationAccountId");

                    b.HasIndex("SourceAccountId");

                    b.ToTable("Transactions", t =>
                        {
                            t.Property("DestinationAccountId")
                                .HasColumnName("Transfer_DestinationAccountId");

                            t.Property("SourceAccountId")
                                .HasColumnName("Transfer_SourceAccountId");
                        });

                    b.HasDiscriminator().HasValue("Transfer");
                });

            modelBuilder.Entity("CategoryTransaction", b =>
                {
                    b.HasOne("Example.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Example.Transaction", null)
                        .WithMany()
                        .HasForeignKey("TransactionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Example.TransactionElement", b =>
                {
                    b.HasOne("Example.TransactionElement", null)
                        .WithMany("Transaction")
                        .HasForeignKey("TransactionElementId");

                    b.HasOne("Example.Transaction", null)
                        .WithMany("Elements")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Example.Expense", b =>
                {
                    b.HasOne("Example.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId");

                    b.HasOne("Example.Account", "SourceAccount")
                        .WithMany()
                        .HasForeignKey("SourceAccountId");

                    b.Navigation("Destination");

                    b.Navigation("SourceAccount");
                });

            modelBuilder.Entity("Example.Income", b =>
                {
                    b.HasOne("Example.Account", "DestinationAccount")
                        .WithMany()
                        .HasForeignKey("DestinationAccountId");

                    b.HasOne("Example.Source", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId");

                    b.Navigation("DestinationAccount");

                    b.Navigation("Source");
                });

            modelBuilder.Entity("Example.Transfer", b =>
                {
                    b.HasOne("Example.Account", "DestinationAccount")
                        .WithMany()
                        .HasForeignKey("DestinationAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Example.Account", "SourceAccount")
                        .WithMany()
                        .HasForeignKey("SourceAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DestinationAccount");

                    b.Navigation("SourceAccount");
                });

            modelBuilder.Entity("Example.Transaction", b =>
                {
                    b.Navigation("Elements");
                });

            modelBuilder.Entity("Example.TransactionElement", b =>
                {
                    b.Navigation("Transaction");
                });
#pragma warning restore 612, 618
        }
    }
}
