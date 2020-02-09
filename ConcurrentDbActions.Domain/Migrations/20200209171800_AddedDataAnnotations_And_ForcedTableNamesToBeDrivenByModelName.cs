using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConcurrentDbActions.Domain.Migrations
{
    public partial class AddedDataAnnotations_And_ForcedTableNamesToBeDrivenByModelName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceHistory_Products_ProductId",
                table: "PriceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceHistory_Users_UpdatedByUserId",
                table: "PriceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Locations_LocationId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Products_ProductId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Warehouses_WarehouseId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_StockHistory_Stock_StockId",
                table: "StockHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_StockHistory_Users_UpdatedByUserId",
                table: "StockHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockHistory",
                table: "StockHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceHistory",
                table: "PriceHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("98836b5f-3c53-4068-8e32-97f0b51f6d21"));

            migrationBuilder.RenameTable(
                name: "Warehouses",
                newName: "Warehouse");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "StockHistory",
                newName: "StockAudit");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "PriceHistory",
                newName: "PriceAudit");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameIndex(
                name: "IX_StockHistory_UpdatedByUserId",
                table: "StockAudit",
                newName: "IX_StockAudit_UpdatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_StockHistory_StockId",
                table: "StockAudit",
                newName: "IX_StockAudit_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceHistory_UpdatedByUserId",
                table: "PriceAudit",
                newName: "IX_PriceAudit_UpdatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceHistory_ProductId",
                table: "PriceAudit",
                newName: "IX_PriceAudit_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockAudit",
                table: "StockAudit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceAudit",
                table: "PriceAudit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Name", "Username" },
                values: new object[] { new Guid("710e5811-4102-4725-976c-65d3bc4c8bec"), "Tom.Smith@CosmicSafari.co.uk", "Tom", "Hingsmaster" });

            migrationBuilder.AddForeignKey(
                name: "FK_PriceAudit_Product_ProductId",
                table: "PriceAudit",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceAudit_User_UpdatedByUserId",
                table: "PriceAudit",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Location_LocationId",
                table: "Stock",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Product_ProductId",
                table: "Stock",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Warehouse_WarehouseId",
                table: "Stock",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockAudit_Stock_StockId",
                table: "StockAudit",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockAudit_User_UpdatedByUserId",
                table: "StockAudit",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceAudit_Product_ProductId",
                table: "PriceAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceAudit_User_UpdatedByUserId",
                table: "PriceAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Location_LocationId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Product_ProductId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Warehouse_WarehouseId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_StockAudit_Stock_StockId",
                table: "StockAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_StockAudit_User_UpdatedByUserId",
                table: "StockAudit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockAudit",
                table: "StockAudit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceAudit",
                table: "PriceAudit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("710e5811-4102-4725-976c-65d3bc4c8bec"));

            migrationBuilder.RenameTable(
                name: "Warehouse",
                newName: "Warehouses");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "StockAudit",
                newName: "StockHistory");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PriceAudit",
                newName: "PriceHistory");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameIndex(
                name: "IX_StockAudit_UpdatedByUserId",
                table: "StockHistory",
                newName: "IX_StockHistory_UpdatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_StockAudit_StockId",
                table: "StockHistory",
                newName: "IX_StockHistory_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceAudit_UpdatedByUserId",
                table: "PriceHistory",
                newName: "IX_PriceHistory_UpdatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceAudit_ProductId",
                table: "PriceHistory",
                newName: "IX_PriceHistory_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockHistory",
                table: "StockHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceHistory",
                table: "PriceHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name", "Username" },
                values: new object[] { new Guid("98836b5f-3c53-4068-8e32-97f0b51f6d21"), "Tom.Smith@CosmicSafari.co.uk", "Tom", "Hingsmaster" });

            migrationBuilder.AddForeignKey(
                name: "FK_PriceHistory_Products_ProductId",
                table: "PriceHistory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceHistory_Users_UpdatedByUserId",
                table: "PriceHistory",
                column: "UpdatedByUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Locations_LocationId",
                table: "Stock",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Products_ProductId",
                table: "Stock",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Warehouses_WarehouseId",
                table: "Stock",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockHistory_Stock_StockId",
                table: "StockHistory",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockHistory_Users_UpdatedByUserId",
                table: "StockHistory",
                column: "UpdatedByUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
