using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RINGAWEB.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPropertyDetailMaps_PropertyProperties_PropertyDetailId",
                table: "ProductPropertyDetailMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyProperties_Properties_PropertyId",
                table: "PropertyProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyProperties",
                table: "PropertyProperties");

            migrationBuilder.RenameTable(
                name: "PropertyProperties",
                newName: "PropertyDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyProperties_PropertyId",
                table: "PropertyDetails",
                newName: "IX_PropertyDetails_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyDetails",
                table: "PropertyDetails",
                column: "PropertyDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPropertyDetailMaps_PropertyDetails_PropertyDetailId",
                table: "ProductPropertyDetailMaps",
                column: "PropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_Properties_PropertyId",
                table: "PropertyDetails",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPropertyDetailMaps_PropertyDetails_PropertyDetailId",
                table: "ProductPropertyDetailMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_Properties_PropertyId",
                table: "PropertyDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyDetails",
                table: "PropertyDetails");

            migrationBuilder.RenameTable(
                name: "PropertyDetails",
                newName: "PropertyProperties");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyDetails_PropertyId",
                table: "PropertyProperties",
                newName: "IX_PropertyProperties_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyProperties",
                table: "PropertyProperties",
                column: "PropertyDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPropertyDetailMaps_PropertyProperties_PropertyDetailId",
                table: "ProductPropertyDetailMaps",
                column: "PropertyDetailId",
                principalTable: "PropertyProperties",
                principalColumn: "PropertyDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyProperties_Properties_PropertyId",
                table: "PropertyProperties",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
