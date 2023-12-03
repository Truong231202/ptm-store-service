using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ptm_store_service.Migrations
{
    /// <inheritdoc />
    public partial class RelationShip_Carts_CartLines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartLines",
                table: "CartLines");

            migrationBuilder.RenameTable(
                name: "CartLines",
                newName: "Cartline");

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductId",
                table: "Cartline",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cartline",
                table: "Cartline",
                column: "CartLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_CartId",
                table: "Cartline",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_ProductsProductId",
                table: "Cartline",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cartline_Carts_CartId",
                table: "Cartline",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cartline_Products_ProductsProductId",
                table: "Cartline",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartline_Carts_CartId",
                table: "Cartline");

            migrationBuilder.DropForeignKey(
                name: "FK_Cartline_Products_ProductsProductId",
                table: "Cartline");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cartline",
                table: "Cartline");

            migrationBuilder.DropIndex(
                name: "IX_Cartline_CartId",
                table: "Cartline");

            migrationBuilder.DropIndex(
                name: "IX_Cartline_ProductsProductId",
                table: "Cartline");

            migrationBuilder.DropColumn(
                name: "ProductsProductId",
                table: "Cartline");

            migrationBuilder.RenameTable(
                name: "Cartline",
                newName: "CartLines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartLines",
                table: "CartLines",
                column: "CartLineId");
        }
    }
}
