﻿// <auto-generated />
using DepoApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepoApp.Migrations
{
    [DbContext(typeof(DepoDbContext))]
    [Migration("20240118232204_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("DepoApp.DAL.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Products");
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
