using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RingaWEB.Migrations
{
    public partial class a1 : Migration
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
                name: "ShopShopTypes",
                columns: table => new
                {
                    ShopShopTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    ShopTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopShopTypes", x => x.ShopShopTypeId);
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
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountOwnerId = table.Column<int>(type: "int", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopeStatusId = table.Column<int>(type: "int", nullable: true),
                    ShopStatusId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "ShopStatusId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Shops_AccountOwnerId",
                table: "Shops",
                column: "AccountOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ShopStatusId",
                table: "Shops",
                column: "ShopStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopeTypes");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "ShopShopTypes");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ShopStatuses");

            migrationBuilder.DropTable(
                name: "AccountGenders");

            migrationBuilder.DropTable(
                name: "AccountRoles");

            migrationBuilder.DropTable(
                name: "AccountStatuses");
        }
    }
}
