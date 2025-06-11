using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Persistence.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initialize3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInStocks_Products_ProductId",
                schema: "Catalog",
                table: "ProductInStocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInStocks",
                schema: "Catalog",
                table: "ProductInStocks");

            migrationBuilder.RenameTable(
                name: "ProductInStocks",
                schema: "Catalog",
                newName: "Stocks",
                newSchema: "Catalog");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInStocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                newName: "IX_Stocks_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                schema: "Catalog",
                table: "Stocks",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 524m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 136m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 181m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 954m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 385m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 632m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 765m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 995m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 861m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 929m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 527m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 879m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 834m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 530m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 536m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 862m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 161m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 115m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 675m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 375m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 448m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 441m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 947m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 208m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 708m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 183m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 846m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 432m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 776m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 167m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 580m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 162m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 472m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 118m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 372m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: 587m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 887m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 770m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 832m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 422m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 129m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 428m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 880m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 875m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "Price",
                value: 715m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "Price",
                value: 725m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 819m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 331m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 160m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 204m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 720m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 594m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 566m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "Price",
                value: 774m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "Price",
                value: 831m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "Price",
                value: 157m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 725m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 284m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "Price",
                value: 706m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "Price",
                value: 748m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "Price",
                value: 323m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "Price",
                value: 701m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "Price",
                value: 303m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "Price",
                value: 266m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "Price",
                value: 430m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "Price",
                value: 665m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "Price",
                value: 997m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "Price",
                value: 199m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "Price",
                value: 405m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "Price",
                value: 459m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "Price",
                value: 905m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "Price",
                value: 328m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "Price",
                value: 651m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "Price",
                value: 317m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "Price",
                value: 641m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "Price",
                value: 899m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "Price",
                value: 103m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "Price",
                value: 615m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "Price",
                value: 928m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "Price",
                value: 376m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "Price",
                value: 153m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "Price",
                value: 299m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "Price",
                value: 510m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "Price",
                value: 123m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "Price",
                value: 433m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "Price",
                value: 577m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "Price",
                value: 277m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "Price",
                value: 760m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "Price",
                value: 126m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "Price",
                value: 463m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "Price",
                value: 330m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "Price",
                value: 323m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "Price",
                value: 110m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "Price",
                value: 351m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "Price",
                value: 384m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 992m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 851m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "Price",
                value: 795m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "Price",
                value: 467m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "Price",
                value: 103m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 67,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 68,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 69,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 70,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 71,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 72,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 73,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 74,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 75,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 76,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 77,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 78,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 79,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 80,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 81,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 82,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 83,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 84,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 86,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 87,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 88,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 89,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 90,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 92,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 93,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 94,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 95,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 98,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 99,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 100,
                column: "Stock",
                value: 8);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                principalSchema: "Catalog",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Products_ProductId",
                schema: "Catalog",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                schema: "Catalog",
                table: "Stocks");

            migrationBuilder.RenameTable(
                name: "Stocks",
                schema: "Catalog",
                newName: "ProductInStocks",
                newSchema: "Catalog");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "ProductInStocks",
                newName: "IX_ProductInStocks_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInStocks",
                schema: "Catalog",
                table: "ProductInStocks",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 21,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 22,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 24,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 25,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 26,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 27,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 28,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 30,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 31,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 32,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 33,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 34,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 35,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 36,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 37,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 38,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 39,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 40,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 41,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 42,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 43,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 44,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 45,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 47,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 48,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 49,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 50,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 52,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 53,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 54,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 55,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 56,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 57,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 58,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 59,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 60,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 61,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 62,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 63,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 64,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 65,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 66,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 67,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 68,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 69,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 70,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 71,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 72,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 73,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 74,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 75,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 76,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 77,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 78,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 79,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 80,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 81,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 82,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 83,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 84,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 86,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 87,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 88,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 89,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 90,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 92,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 93,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 94,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 95,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 98,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 99,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "ProductInStocks",
                keyColumn: "Id",
                keyValue: 100,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 166m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 594m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 545m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 824m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 505m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 532m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 719m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 163m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 337m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 791m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 965m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 875m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 971m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 963m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 192m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 927m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 150m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 501m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 462m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 597m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 559m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 187m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 619m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 810m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 903m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 222m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 171m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 241m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 662m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 502m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 293m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 827m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 692m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 791m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: 228m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 592m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 173m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 822m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 317m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 352m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 960m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 168m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 918m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "Price",
                value: 696m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "Price",
                value: 122m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 185m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 651m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 190m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 627m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 210m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 802m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 642m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "Price",
                value: 963m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "Price",
                value: 197m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "Price",
                value: 870m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 486m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 223m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "Price",
                value: 965m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "Price",
                value: 311m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "Price",
                value: 456m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "Price",
                value: 175m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "Price",
                value: 521m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "Price",
                value: 949m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "Price",
                value: 630m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "Price",
                value: 695m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "Price",
                value: 137m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "Price",
                value: 573m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "Price",
                value: 246m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "Price",
                value: 610m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "Price",
                value: 161m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "Price",
                value: 592m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "Price",
                value: 965m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "Price",
                value: 458m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "Price",
                value: 221m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "Price",
                value: 178m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "Price",
                value: 615m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "Price",
                value: 562m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "Price",
                value: 529m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "Price",
                value: 770m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "Price",
                value: 600m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "Price",
                value: 131m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "Price",
                value: 496m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "Price",
                value: 893m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "Price",
                value: 637m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "Price",
                value: 580m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "Price",
                value: 305m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "Price",
                value: 728m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "Price",
                value: 944m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "Price",
                value: 280m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "Price",
                value: 837m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "Price",
                value: 946m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "Price",
                value: 250m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "Price",
                value: 508m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "Price",
                value: 464m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 444m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 551m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "Price",
                value: 752m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "Price",
                value: 360m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "Price",
                value: 574m);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInStocks_Products_ProductId",
                schema: "Catalog",
                table: "ProductInStocks",
                column: "ProductId",
                principalSchema: "Catalog",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
