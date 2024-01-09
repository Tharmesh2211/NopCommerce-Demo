using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entites.Migrations
{
    /// <inheritdoc />
    public partial class Testing3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Shipping",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_ProductID",
                table: "Shipping",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipping_Product_ProductID",
                table: "Shipping",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipping_Product_ProductID",
                table: "Shipping");

            migrationBuilder.DropIndex(
                name: "IX_Shipping_ProductID",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Shipping");
        }
    }
}
