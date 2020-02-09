﻿// <auto-generated />
using System;
using ConcurrentDbActions.Domain.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConcurrentDbActions.Domain.Migrations
{
    [DbContext(typeof(StockroomDbContext))]
    [Migration("20200206015229_Alpha001_Updated-Primary-Keys-To-All-Be-Named-Id")]
    partial class Alpha001_UpdatedPrimaryKeysToAllBeNamedId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.PriceAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("ModificationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UpdatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UpdatedPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("PriceHistory");
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.StockAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("StockId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UpdatedByUserId")
                        .HasColumnType("TEXT");

                    b.Property<double>("UpdatedQuantity")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("StockHistory");
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("WarehouseType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.PriceAudit", b =>
                {
                    b.HasOne("ConcurrentDbActions.Domain.Models.Product", "Product")
                        .WithMany("PriceAudits")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConcurrentDbActions.Domain.Models.User", "UpdatedByUser")
                        .WithMany("PriceAudits")
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.Stock", b =>
                {
                    b.HasOne("ConcurrentDbActions.Domain.Models.Location", "Location")
                        .WithMany("Stock")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConcurrentDbActions.Domain.Models.Product", "Product")
                        .WithMany("Stock")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConcurrentDbActions.Domain.Models.Warehouse", "Warehouse")
                        .WithMany("Stock")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConcurrentDbActions.Domain.Models.StockAudit", b =>
                {
                    b.HasOne("ConcurrentDbActions.Domain.Models.Stock", "Stock")
                        .WithMany("StockAudits")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConcurrentDbActions.Domain.Models.User", "UpdatedByUser")
                        .WithMany("StockAudits")
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
