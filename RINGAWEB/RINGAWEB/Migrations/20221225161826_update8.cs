using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RINGAWEB.Migrations
{
    public partial class update8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductImgId",
                table: "PropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductImgs",
                columns: table => new
                {
                    ProductImgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsProductAvatar = table.Column<bool>(type: "bit", nullable: false),
                    ProductImgData = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImgs", x => x.ProductImgId);
                    table.ForeignKey(
                        name: "FK_ProductImgs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_ProductImgId",
                table: "PropertyDetails",
                column: "ProductImgId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImgs_ProductId",
                table: "ProductImgs",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_ProductImgs_ProductImgId",
                table: "PropertyDetails",
                column: "ProductImgId",
                principalTable: "ProductImgs",
                principalColumn: "ProductImgId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_ProductImgs_ProductImgId",
                table: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "ProductImgs");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_ProductImgId",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ProductImgId",
                table: "PropertyDetails");
        }
    }
}
