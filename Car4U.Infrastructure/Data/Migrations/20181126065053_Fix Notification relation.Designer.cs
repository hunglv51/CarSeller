﻿// <auto-generated />
using System;
using Car4U.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Car4U.Infrastructure.Migrations
{
    [DbContext(typeof(CarSellerContext))]
    [Migration("20181126065053_Fix Notification relation")]
    partial class FixNotificationrelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Car4U.Domain.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsSalon");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.Car", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CylinderCapacity");

                    b.Property<int>("DrivenDistance");

                    b.Property<int?>("FuelCapacity");

                    b.Property<int>("ManufactureYear");

                    b.Property<int?>("MaxSeatingCapacity");

                    b.Property<int?>("NumDoor");

                    b.Property<Guid?>("PostId");

                    b.Property<double>("Price");

                    b.Property<string>("Size")
                        .HasMaxLength(50);

                    b.Property<int?>("TireInfo");

                    b.Property<int?>("Weight");

                    b.Property<int?>("WheelBase");

                    b.HasKey("Id");

                    b.HasIndex("PostId")
                        .IsUnique();

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.CarImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CarId");

                    b.Property<int>("Height");

                    b.Property<int>("Type");

                    b.Property<string>("Uri");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarImages");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsRead");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid?>("PostId");

                    b.Property<string>("Title");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("ExpiredDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("PostCategoryId");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.PostCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName")
                        .HasMaxLength(50);

                    b.Property<string>("CarFamily")
                        .HasMaxLength(50);

                    b.Property<int>("CarType");

                    b.Property<int>("DriveType");

                    b.Property<bool>("IsImported");

                    b.Property<bool>("IsUsed");

                    b.Property<int>("Transmission");

                    b.HasKey("Id");

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.Car", b =>
                {
                    b.HasOne("Car4U.Domain.Entities.Post", "Post")
                        .WithOne("Car")
                        .HasForeignKey("Car4U.Domain.Entities.Car", "PostId");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.CarImage", b =>
                {
                    b.HasOne("Car4U.Domain.Entities.Car", "Car")
                        .WithMany("Images")
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.Notification", b =>
                {
                    b.HasOne("Car4U.Domain.Entities.Post", "Post")
                        .WithMany("Notifications")
                        .HasForeignKey("PostId");

                    b.HasOne("Car4U.Domain.Entities.AppUser", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Car4U.Domain.Entities.Post", b =>
                {
                    b.HasOne("Car4U.Domain.Entities.PostCategory", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("PostCategoryId");

                    b.HasOne("Car4U.Domain.Entities.AppUser", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
