﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RingaWEB.Context;

#nullable disable

namespace RingaWEB.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("Sex")
                        .HasColumnType("int");

                    b.Property<int?>("StarPoint")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex("RoleId");

                    b.HasIndex("Sex");

                    b.HasIndex("StatusId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.AccountGender", b =>
                {
                    b.Property<int>("AccountGenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountGenderId"), 1L, 1);

                    b.Property<string>("AccountGenderCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountGenderDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountGenderId");

                    b.ToTable("AccountGenders");
                });

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.AccountRole", b =>
                {
                    b.Property<int>("AccountRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountRoleId"), 1L, 1);

                    b.Property<string>("AccountRoleCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountRoleDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountRoleId");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.AccountStatus", b =>
                {
                    b.Property<int>("AccountStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountStatusId"), 1L, 1);

                    b.Property<string>("AccountStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountStatusDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountStatusId");

                    b.ToTable("AccountStatuses");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailId"), 1L, 1);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductPropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<double?>("ShellPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductDetailId");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.ProductDetailPropertyDetail", b =>
                {
                    b.Property<int>("ProductDetailPropertyDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailPropertyDetailId"), 1L, 1);

                    b.Property<int?>("ProductDetailId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("PropertyDetailId")
                        .HasColumnType("int");

                    b.HasKey("ProductDetailPropertyDetailId");

                    b.HasIndex("ProductDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PropertyDetailId");

                    b.ToTable("ProductDetailPropertyDetails");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.ProductImg", b =>
                {
                    b.Property<int>("ProductImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImgId"), 1L, 1);

                    b.Property<bool?>("IsProductAvatar")
                        .HasColumnType("bit");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<byte[]>("ProductImgData")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ProductImgId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImgs");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"), 1L, 1);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropertySort")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.HasIndex("ProductId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.PropertyDetail", b =>
                {
                    b.Property<int>("PropertyDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyDetailId"), 1L, 1);

                    b.Property<int?>("ProductImgId")
                        .HasColumnType("int");

                    b.Property<string>("PropertyDetailCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyDetailDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("PropertyDetailId");

                    b.HasIndex("ProductImgId");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyDetails");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopId"), 1L, 1);

                    b.Property<int>("AccountOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("ShopeStatusId")
                        .HasColumnType("int");

                    b.HasKey("ShopId");

                    b.HasIndex("AccountOwnerId");

                    b.HasIndex("ShopStatusId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.ShopeType", b =>
                {
                    b.Property<int>("ShopeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopeTypeId"), 1L, 1);

                    b.Property<string>("ShopeTypeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopeTypeDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopeTypeId");

                    b.ToTable("ShopeTypes");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.ShopShopType", b =>
                {
                    b.Property<int>("ShopShopTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopShopTypeId"), 1L, 1);

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<int?>("ShopTypeId")
                        .HasColumnType("int");

                    b.HasKey("ShopShopTypeId");

                    b.ToTable("ShopShopTypes");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.ShopStatus", b =>
                {
                    b.Property<int>("ShopStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopStatusId"), 1L, 1);

                    b.Property<string>("ShopStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopStatusDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopStatusId");

                    b.ToTable("ShopStatuses");
                });

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.Account", b =>
                {
                    b.HasOne("RingaWEB.Entities.AccountPkg.AccountRole", "AccountRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("RingaWEB.Entities.AccountPkg.AccountGender", "AccountGender")
                        .WithMany()
                        .HasForeignKey("Sex");

                    b.HasOne("RingaWEB.Entities.AccountPkg.AccountStatus", "AccountStatus")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("AccountGender");

                    b.Navigation("AccountRole");

                    b.Navigation("AccountStatus");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.ProductDetail", b =>
                {
                    b.HasOne("RingaWEB.Entities.ProductPkg.ProductDetail", "ParentProductDetail")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("ParentProductDetail");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.ProductDetailPropertyDetail", b =>
                {
                    b.HasOne("RingaWEB.Entities.ProductPkg.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetailId");

                    b.HasOne("RingaWEB.Entities.ProductPkg.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("RingaWEB.Entities.ProductPkg.PropertyDetail", "PropertyDetail")
                        .WithMany()
                        .HasForeignKey("PropertyDetailId");

                    b.Navigation("Product");

                    b.Navigation("ProductDetail");

                    b.Navigation("PropertyDetail");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.ProductImg", b =>
                {
                    b.HasOne("RingaWEB.Entities.ProductPkg.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.Property", b =>
                {
                    b.HasOne("RingaWEB.Entities.ProductPkg.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.PropertyDetail", b =>
                {
                    b.HasOne("RingaWEB.Entities.ProductPkg.ProductImg", "ProductImg")
                        .WithMany()
                        .HasForeignKey("ProductImgId");

                    b.HasOne("RingaWEB.Entities.ProductPkg.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId");

                    b.Navigation("ProductImg");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.Shop", b =>
                {
                    b.HasOne("RingaWEB.Entities.AccountPkg.Account", "AccountOwner")
                        .WithMany()
                        .HasForeignKey("AccountOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RingaWEB.Entities.ShopPkg.ShopStatus", "ShopStatus")
                        .WithMany()
                        .HasForeignKey("ShopStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountOwner");

                    b.Navigation("ShopStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
