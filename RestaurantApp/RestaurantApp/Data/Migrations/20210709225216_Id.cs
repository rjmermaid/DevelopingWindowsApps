using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Data.Migrations
{
    public partial class Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemShoppingCart_ShoppingCarts_shoppingCartsShoppingCartId",
                table: "ItemShoppingCart");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingCarts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "shoppingCartsShoppingCartId",
                table: "ItemShoppingCart",
                newName: "shoppingCartsId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemShoppingCart_shoppingCartsShoppingCartId",
                table: "ItemShoppingCart",
                newName: "IX_ItemShoppingCart_shoppingCartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemShoppingCart_ShoppingCarts_shoppingCartsId",
                table: "ItemShoppingCart",
                column: "shoppingCartsId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemShoppingCart_ShoppingCarts_shoppingCartsId",
                table: "ItemShoppingCart");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShoppingCarts",
                newName: "ShoppingCartId");

            migrationBuilder.RenameColumn(
                name: "shoppingCartsId",
                table: "ItemShoppingCart",
                newName: "shoppingCartsShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemShoppingCart_shoppingCartsId",
                table: "ItemShoppingCart",
                newName: "IX_ItemShoppingCart_shoppingCartsShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemShoppingCart_ShoppingCarts_shoppingCartsShoppingCartId",
                table: "ItemShoppingCart",
                column: "shoppingCartsShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
