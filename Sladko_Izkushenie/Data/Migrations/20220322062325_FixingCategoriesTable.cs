using Microsoft.EntityFrameworkCore.Migrations;

namespace Sladko_Izkushenie.Data.Migrations
{
    public partial class FixingCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductsId",
                table: "Categories",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_ProductsId",
                table: "Categories",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_ProductsId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductsId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Categories");
        }
    }
}
