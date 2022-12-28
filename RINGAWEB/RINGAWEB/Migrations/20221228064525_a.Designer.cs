﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RingaWEB.Context;

#nullable disable

namespace RingaWEB.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221228064525_a")]
    partial class a
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDay")
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

                    b.Property<DateTime?>("UpdateDateTime")
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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountGenderId"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountRoleId"));

                    b.Property<string>("AccountRoleCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountRoleDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountRoleId");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.AccountShipContact", b =>
                {
                    b.Property<int>("AccountShipContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountShipContactId"));

                    b.Property<string>("AccountShipContactCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReveiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReveicePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountShipContactId");

                    b.ToTable("AccountShipContacts");
                });

            modelBuilder.Entity("RingaWEB.Entities.AccountPkg.AccountStatus", b =>
                {
                    b.Property<int>("AccountStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountStatusId"));

                    b.Property<string>("AccountStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountStatusDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountStatusId");

                    b.ToTable("AccountStatuses");
                });

            modelBuilder.Entity("RingaWEB.Entities.BillPkg.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<string>("BillCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BillStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("BuyMethodId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CloseDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ShipMethodId")
                        .HasColumnType("int");

                    b.Property<double?>("ShipPrice")
                        .HasColumnType("float");

                    b.Property<int?>("StarPoint")
                        .HasColumnType("int");

                    b.Property<double?>("TotalBillAfterEverything")
                        .HasColumnType("float");

                    b.Property<double?>("TotalBillAfterVoucher")
                        .HasColumnType("float");

                    b.Property<double?>("TotalBillBeforeVoucher")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VoucherBillId")
                        .HasColumnType("int");

                    b.Property<int?>("VoucherShipId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("BillStatusId");

                    b.HasIndex("BuyMethodId");

                    b.HasIndex("ShipMethodId");

                    b.HasIndex("VoucherBillId");

                    b.HasIndex("VoucherShipId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("RingaWEB.Entities.BillPkg.BillStatus", b =>
                {
                    b.Property<int>("BillStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillStatusId"));

                    b.Property<string>("BillStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillStatusDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillStatusId");

                    b.ToTable("BillStatuses");
                });

            modelBuilder.Entity("RingaWEB.Entities.BillPkg.BuyMethod", b =>
                {
                    b.Property<int>("BuyMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuyMethodId"));

                    b.Property<string>("BuyMethodCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyMethodDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyMethodId");

                    b.ToTable("BuyMethods");
                });

            modelBuilder.Entity("RingaWEB.Entities.BillPkg.ShipMethod", b =>
                {
                    b.Property<int>("ShipMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipMethodId"));

                    b.Property<string>("ShipMethodCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipMethodDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipMethodId");

                    b.ToTable("ShipMethods");
                });

            modelBuilder.Entity("RingaWEB.Entities.ProductPkg.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailId"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailPropertyDetailId"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImgId"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyDetailId"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopId"));

                    b.Property<int>("AccountOwnerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShopCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShopStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("ShopeStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShopId");

                    b.HasIndex("AccountOwnerId");

                    b.HasIndex("ShopStatusId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.ShopShopType", b =>
                {
                    b.Property<int>("ShopShopTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopShopTypeId"));

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<int?>("ShopTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ShopShopTypeId");

                    b.HasIndex("ShopId");

                    b.HasIndex("ShopTypeId");

                    b.ToTable("ShopShopTypes");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.ShopStatus", b =>
                {
                    b.Property<int>("ShopStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopStatusId"));

                    b.Property<string>("ShopStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopStatusDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopStatusId");

                    b.ToTable("ShopStatuses");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.ShopeType", b =>
                {
                    b.Property<int>("ShopeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopeTypeId"));

                    b.Property<string>("ShopeTypeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopeTypeDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopeTypeId");

                    b.ToTable("ShopeTypes");
                });

            modelBuilder.Entity("RingaWEB.Entities.VoucherPkg.Voucher", b =>
                {
                    b.Property<int>("VoucherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoucherId"));

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("VoucherCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoucherDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoucherTypeId")
                        .HasColumnType("int");

                    b.Property<double?>("VoucherValue")
                        .HasColumnType("float");

                    b.HasKey("VoucherId");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("RingaWEB.Entities.VoucherPkg.VoucherType", b =>
                {
                    b.Property<int>("VoucherTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoucherTypeId"));

                    b.Property<string>("VoucherTypeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoucherTypeDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VoucherTypeId");

                    b.ToTable("VoucherTypes");
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

            modelBuilder.Entity("RingaWEB.Entities.BillPkg.Bill", b =>
                {
                    b.HasOne("RingaWEB.Entities.BillPkg.BillStatus", "BillStatus")
                        .WithMany()
                        .HasForeignKey("BillStatusId");

                    b.HasOne("RingaWEB.Entities.BillPkg.BuyMethod", "BuyMethod")
                        .WithMany()
                        .HasForeignKey("BuyMethodId");

                    b.HasOne("RingaWEB.Entities.BillPkg.ShipMethod", "ShipMethod")
                        .WithMany()
                        .HasForeignKey("ShipMethodId");

                    b.HasOne("RingaWEB.Entities.VoucherPkg.Voucher", "VoucherBill")
                        .WithMany()
                        .HasForeignKey("VoucherBillId");

                    b.HasOne("RingaWEB.Entities.VoucherPkg.Voucher", "VoucherShip")
                        .WithMany()
                        .HasForeignKey("VoucherShipId");

                    b.Navigation("BillStatus");

                    b.Navigation("BuyMethod");

                    b.Navigation("ShipMethod");

                    b.Navigation("VoucherBill");

                    b.Navigation("VoucherShip");
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
                        .HasForeignKey("ShopStatusId");

                    b.Navigation("AccountOwner");

                    b.Navigation("ShopStatus");
                });

            modelBuilder.Entity("RingaWEB.Entities.ShopPkg.ShopShopType", b =>
                {
                    b.HasOne("RingaWEB.Entities.ShopPkg.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.HasOne("RingaWEB.Entities.ShopPkg.ShopeType", "ShopType")
                        .WithMany()
                        .HasForeignKey("ShopTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");

                    b.Navigation("ShopType");
                });
#pragma warning restore 612, 618
        }
    }
}