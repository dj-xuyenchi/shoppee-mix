using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RINGAWEB.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductProperties",
                columns: table => new
                {
                    ProductPropertyDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPropertyDetailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ShellPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperties", x => x.ProductPropertyDetailId);
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
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertySort = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProperties",
                columns: table => new
                {
                    PropertyDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    PropertyDetailCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyDetailDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProperties", x => x.PropertyDetailId);
                    table.ForeignKey(
                        name: "FK_PropertyProperties_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPropertyDetailMaps",
                columns: table => new
                {
                    ProductPropertyDetailMapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyDetailId = table.Column<int>(type: "int", nullable: false),
                    ProductPropertyDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPropertyDetailMaps", x => x.ProductPropertyDetailMapId);
                    table.ForeignKey(
                        name: "FK_ProductPropertyDetailMaps_ProductProperties_ProductPropertyDetailId",
                        column: x => x.ProductPropertyDetailId,
                        principalTable: "ProductProperties",
                        principalColumn: "ProductPropertyDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPropertyDetailMaps_PropertyProperties_PropertyDetailId",
                        column: x => x.PropertyDetailId,
                        principalTable: "PropertyProperties",
                        principalColumn: "PropertyDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropertyDetailMaps_ProductPropertyDetailId",
                table: "ProductPropertyDetailMaps",
                column: "ProductPropertyDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropertyDetailMaps_PropertyDetailId",
                table: "ProductPropertyDetailMaps",
                column: "PropertyDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ProductId",
                table: "Properties",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProperties_PropertyId",
                table: "PropertyProperties",
                column: "PropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPropertyDetailMaps");

            migrationBuilder.DropTable(
                name: "ProductProperties");

            migrationBuilder.DropTable(
                name: "PropertyProperties");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
