using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RingaWEB.Migrations
{
    /// <inheritdoc />
    public partial class up2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShellPrice",
                table: "ProductDetails",
                newName: "SellPrice");

            migrationBuilder.AddColumn<double>(
                name: "MaximunValue",
                table: "Vouchers",
                type: "float",
                nullable: true);

             migrationBuilder.AddColumn<double>(
                name: "MinimunTotalBillAccept",
                table: "Vouchers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoucherStatusId",
                table: "Vouchers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoucherShopId",
                table: "Bills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VoucherStatus",
                columns: table => new
                {
                    VoucherStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherStatusDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherStatus", x => x.VoucherStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_VoucherStatusId",
                table: "Vouchers",
                column: "VoucherStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_VoucherShopId",
                table: "Bills",
                column: "VoucherShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Vouchers_VoucherShopId",
                table: "Bills",
                column: "VoucherShopId",
                principalTable: "Vouchers",
                principalColumn: "VoucherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_VoucherStatus_VoucherStatusId",
                table: "Vouchers",
                column: "VoucherStatusId",
                principalTable: "VoucherStatus",
                principalColumn: "VoucherStatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Vouchers_VoucherShopId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_VoucherStatus_VoucherStatusId",
                table: "Vouchers");

            migrationBuilder.DropTable(
                name: "VoucherStatus");

            migrationBuilder.DropIndex(
                name: "IX_Vouchers_VoucherStatusId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Bills_VoucherShopId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "MaximunValue",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "MinimunTotalBillAccept",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "VoucherStatusId",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "VoucherShopId",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "SellPrice",
                table: "ProductDetails",
                newName: "ShellPrice");
        }
    }
}
