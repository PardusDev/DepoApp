﻿// <auto-generated />
using System;
using DepoApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepoApp.Migrations
{
    [DbContext(typeof(DepoDbContext))]
    partial class DepoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("DepoApp.DAL.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("barcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("categoryid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("measurementType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("categoryid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.Sale", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("count")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.Property<int>("storageItemid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("storageItemid");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.Storage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.StorageItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("storageid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.HasIndex("storageid");

                    b.ToTable("StorageItems");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.StorageItemLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("count")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("storageItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("transactionType")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("StorageItemLogs");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.Product", b =>
                {
                    b.HasOne("DepoApp.DAL.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.Sale", b =>
                {
                    b.HasOne("DepoApp.DAL.Models.StorageItem", "storageItem")
                        .WithMany()
                        .HasForeignKey("storageItemid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("storageItem");
                });

            modelBuilder.Entity("DepoApp.DAL.Models.StorageItem", b =>
                {
                    b.HasOne("DepoApp.DAL.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepoApp.DAL.Models.Storage", "storage")
                        .WithMany()
                        .HasForeignKey("storageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("storage");
                });
#pragma warning restore 612, 618
        }
    }
}
