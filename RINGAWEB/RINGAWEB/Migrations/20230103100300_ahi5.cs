using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RingaWEB.Migrations
{
    /// <inheritdoc />
    public partial class ahi5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductShowName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductShowName",
                table: "Products");
        }
    }
}
