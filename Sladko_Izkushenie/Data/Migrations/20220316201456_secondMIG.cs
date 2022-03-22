using Microsoft.EntityFrameworkCore.Migrations;

namespace Sladko_Izkushenie.Data.Migrations
{
    public partial class secondMIG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Orders_OrdersId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_ProductsId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrdersId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OrderDetails_OrderDetailsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductsId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_OrdersId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "OrderDetailsId",
                table: "Products",
                newName: "CatergoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_OrderDetailsId",
                table: "Products",
                newName: "IX_Products_CatergoriesId");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "OrderDetails",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrdersId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductsId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsersId",
                table: "Orders",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductsId",
                table: "OrderDetails",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UsersId",
                table: "Orders",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CatergoriesId",
                table: "Products",
                column: "CatergoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductsId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UsersId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CatergoriesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UsersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "CatergoriesId",
                table: "Products",
                newName: "OrderDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CatergoriesId",
                table: "Products",
                newName: "IX_Products_OrderDetailsId");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "OrderDetails",
                newName: "OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductsId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrdersId");

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductsId",
                table: "Categories",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OrdersId",
                table: "AspNetUsers",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Orders_OrdersId",
                table: "AspNetUsers",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_ProductsId",
                table: "Categories",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrdersId",
                table: "OrderDetails",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderDetails_OrderDetailsId",
                table: "Products",
                column: "OrderDetailsId",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
