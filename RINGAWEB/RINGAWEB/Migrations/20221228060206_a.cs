using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RingaWEB.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountGenders",
                columns: table => new
                {
                    AccountGenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountGenderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountGenderDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountGenders", x => x.AccountGenderId);
                });

            migrationBuilder.CreateTable(
                name: "AccountRoles",
                columns: table => new
                {
                    AccountRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountRoleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountRoleDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRoles", x => x.AccountRoleId);
                });

            migrationBuilder.CreateTable(
                name: "AccountShipContacts",
                columns: table => new
                {
                    AccountShipContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReveiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReveicePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountShipContacts", x => x.AccountShipContactId);
                });

            migrationBuilder.CreateTable(
                name: "AccountStatuses",
                columns: table => new
                {
                    AccountStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountStatusDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountStatuses", x => x.AccountStatusId);
                });

            migrationBuilder.CreateTable(
                name: "BillStatuses",
                columns: table => new
                {
                    BillStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillStatusDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillStatuses", x => x.BillStatusId);
                });

            migrationBuilder.CreateTable(
                name: "BuyMethods",
                columns: table => new
                {
                    BuyMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyMethodCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyMethodDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyMethods", x => x.BuyMethodId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    ShellPrice = table.Column<double>(type: "float", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetailId);
                    table.ForeignKey(
                        name: "FK_ProductDetails_ProductDetails_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProductDetails",
                        principalColumn: "ProductDetailId");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ShipMethods",
                columns: table => new
                {
                    ShipMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipMethodCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipMethodDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipMethods", x => x.ShipMethodId);
                });

            migrationBuilder.CreateTable(
                name: "ShopeTypes",
                columns: table => new
                {
                    ShopeTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopeTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopeTypeDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopeTypes", x => x.ShopeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ShopStatuses",
                columns: table => new
                {
                    ShopStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopStatusDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopStatuses", x => x.ShopStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    VoucherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VoucherValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherId);
                });

            migrationBuilder.CreateTable(
                name: "VoucherTypes",
                columns: table => new
                {
                    VoucherTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherTypeDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherTypes", x => x.VoucherTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarPoint = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountGenders_Sex",
                        column: x => x.Sex,
                        principalTable: "AccountGenders",
                        principalColumn: "AccountGenderId");
                    table.ForeignKey(
                        name: "FK_Accounts_AccountRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AccountRoles",
                        principalColumn: "AccountRoleId");
                    table.ForeignKey(
                        name: "FK_Accounts_AccountStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AccountStatuses",
                        principalColumn: "AccountStatusId");
                });

            migrationBuilder.CreateTable(
                name: "ProductImgs",
                columns: table => new
                {
                    ProductImgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    IsProductAvatar = table.Column<bool>(type: "bit", nullable: true),
                    ProductImgData = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImgs", x => x.ProductImgId);
                    table.ForeignKey(
                        name: "FK_ProductImgs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertySort = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillStatusId = table.Column<int>(type: "int", nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalBillBeforeVoucher = table.Column<double>(type: "float", nullable: true),
                    TotalBillAfterVoucher = table.Column<double>(type: "float", nullable: true),
                    ShipPrice = table.Column<double>(type: "float", nullable: true),
                    StarPoint = table.Column<int>(type: "int", nullable: true),
                    TotalBillAfterEverything = table.Column<double>(type: "float", nullable: true),
                    VoucherBillId = table.Column<int>(type: "int", nullable: true),
                    VoucherShipId = table.Column<int>(type: "int", nullable: true),
                    BuyMethodId = table.Column<int>(type: "int", nullable: true),
                    ShipMethodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_BillStatuses_BillStatusId",
                        column: x => x.BillStatusId,
                        principalTable: "BillStatuses",
                        principalColumn: "BillStatusId");
                    table.ForeignKey(
                        name: "FK_Bills_BuyMethods_BuyMethodId",
                        column: x => x.BuyMethodId,
                        principalTable: "BuyMethods",
                        principalColumn: "BuyMethodId");
                    table.ForeignKey(
                        name: "FK_Bills_ShipMethods_ShipMethodId",
                        column: x => x.ShipMethodId,
                        principalTable: "ShipMethods",
                        principalColumn: "ShipMethodId");
                    table.ForeignKey(
                        name: "FK_Bills_Vouchers_VoucherBillId",
                        column: x => x.VoucherBillId,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherId");
                    table.ForeignKey(
                        name: "FK_Bills_Vouchers_VoucherShipId",
                        column: x => x.VoucherShipId,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherId");
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountOwnerId = table.Column<int>(type: "int", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopeStatusId = table.Column<int>(type: "int", nullable: true),
                    ShopStatusId = table.Column<int>(type: "int", nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                    table.ForeignKey(
                        name: "FK_Shops_Accounts_AccountOwnerId",
                        column: x => x.AccountOwnerId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shops_ShopStatuses_ShopStatusId",
                        column: x => x.ShopStatusId,
                        principalTable: "ShopStatuses",
                        principalColumn: "ShopStatusId");
                });

            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    PropertyDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    PropertyDetailCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyDetailDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImgId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.PropertyDetailId);
                    table.ForeignKey(
                        name: "FK_PropertyDetails_ProductImgs_ProductImgId",
                        column: x => x.ProductImgId,
                        principalTable: "ProductImgs",
                        principalColumn: "ProductImgId");
                    table.ForeignKey(
                        name: "FK_PropertyDetails_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId");
                });

            migrationBuilder.CreateTable(
                name: "ShopShopTypes",
                columns: table => new
                {
                    ShopShopTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    ShopTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopShopTypes", x => x.ShopShopTypeId);
                    table.ForeignKey(
                        name: "FK_ShopShopTypes_ShopeTypes_ShopTypeId",
                        column: x => x.ShopTypeId,
                        principalTable: "ShopeTypes",
                        principalColumn: "ShopeTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopShopTypes_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "ShopId");
                });

            migrationBuilder.CreateTable(
                name: "ProductDetailPropertyDetails",
                columns: table => new
                {
                    ProductDetailPropertyDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDetailId = table.Column<int>(type: "int", nullable: true),
                    PropertyDetailId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetailPropertyDetails", x => x.ProductDetailPropertyDetailId);
                    table.ForeignKey(
                        name: "FK_ProductDetailPropertyDetails_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "ProductDetailId");
                    table.ForeignKey(
                        name: "FK_ProductDetailPropertyDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailId",
                        column: x => x.PropertyDetailId,
                        principalTable: "PropertyDetails",
                        principalColumn: "PropertyDetailId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Sex",
                table: "Accounts",
                column: "Sex");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_StatusId",
                table: "Accounts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillStatusId",
                table: "Bills",
                column: "BillStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BuyMethodId",
                table: "Bills",
                column: "BuyMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ShipMethodId",
                table: "Bills",
                column: "ShipMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_VoucherBillId",
                table: "Bills",
                column: "VoucherBillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_VoucherShipId",
                table: "Bills",
                column: "VoucherShipId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetailPropertyDetails_ProductDetailId",
                table: "ProductDetailPropertyDetails",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetailPropertyDetails_ProductId",
                table: "ProductDetailPropertyDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetailPropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ParentId",
                table: "ProductDetails",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImgs_ProductId",
                table: "ProductImgs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ProductId",
                table: "Properties",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_ProductImgId",
                table: "PropertyDetails",
                column: "ProductImgId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_PropertyId",
                table: "PropertyDetails",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_AccountOwnerId",
                table: "Shops",
                column: "AccountOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ShopStatusId",
                table: "Shops",
                column: "ShopStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopShopTypes_ShopId",
                table: "ShopShopTypes",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopShopTypes_ShopTypeId",
                table: "ShopShopTypes",
                column: "ShopTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountShipContacts");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ProductDetailPropertyDetails");

            migrationBuilder.DropTable(
                name: "ShopShopTypes");

            migrationBuilder.DropTable(
                name: "VoucherTypes");

            migrationBuilder.DropTable(
                name: "BillStatuses");

            migrationBuilder.DropTable(
                name: "BuyMethods");

            migrationBuilder.DropTable(
                name: "ShipMethods");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "ShopeTypes");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "ProductImgs");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ShopStatuses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AccountGenders");

            migrationBuilder.DropTable(
                name: "AccountRoles");

            migrationBuilder.DropTable(
                name: "AccountStatuses");
        }
    }
}
