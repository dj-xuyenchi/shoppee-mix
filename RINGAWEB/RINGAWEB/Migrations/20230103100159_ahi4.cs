using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RingaWEB.Migrations
{
    /// <inheritdoc />
    public partial class ahi4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyDetailId",
                table: "ProductDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetails",
                column: "PropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyDetailId",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetails",
                column: "PropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
