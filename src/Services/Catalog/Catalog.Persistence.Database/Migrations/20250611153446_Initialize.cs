using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Persistence.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInStocks",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInStocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 606m },
                    { 2, "Description for product 2", "Product 2", 550m },
                    { 3, "Description for product 3", "Product 3", 483m },
                    { 4, "Description for product 4", "Product 4", 358m },
                    { 5, "Description for product 5", "Product 5", 766m },
                    { 6, "Description for product 6", "Product 6", 904m },
                    { 7, "Description for product 7", "Product 7", 264m },
                    { 8, "Description for product 8", "Product 8", 619m },
                    { 9, "Description for product 9", "Product 9", 500m },
                    { 10, "Description for product 10", "Product 10", 337m },
                    { 11, "Description for product 11", "Product 11", 626m },
                    { 12, "Description for product 12", "Product 12", 437m },
                    { 13, "Description for product 13", "Product 13", 606m },
                    { 14, "Description for product 14", "Product 14", 794m },
                    { 15, "Description for product 15", "Product 15", 148m },
                    { 16, "Description for product 16", "Product 16", 586m },
                    { 17, "Description for product 17", "Product 17", 374m },
                    { 18, "Description for product 18", "Product 18", 497m },
                    { 19, "Description for product 19", "Product 19", 482m },
                    { 20, "Description for product 20", "Product 20", 344m },
                    { 21, "Description for product 21", "Product 21", 890m },
                    { 22, "Description for product 22", "Product 22", 743m },
                    { 23, "Description for product 23", "Product 23", 287m },
                    { 24, "Description for product 24", "Product 24", 998m },
                    { 25, "Description for product 25", "Product 25", 261m },
                    { 26, "Description for product 26", "Product 26", 549m },
                    { 27, "Description for product 27", "Product 27", 228m },
                    { 28, "Description for product 28", "Product 28", 731m },
                    { 29, "Description for product 29", "Product 29", 886m },
                    { 30, "Description for product 30", "Product 30", 415m },
                    { 31, "Description for product 31", "Product 31", 813m },
                    { 32, "Description for product 32", "Product 32", 554m },
                    { 33, "Description for product 33", "Product 33", 886m },
                    { 34, "Description for product 34", "Product 34", 200m },
                    { 35, "Description for product 35", "Product 35", 934m },
                    { 36, "Description for product 36", "Product 36", 442m },
                    { 37, "Description for product 37", "Product 37", 730m },
                    { 38, "Description for product 38", "Product 38", 720m },
                    { 39, "Description for product 39", "Product 39", 542m },
                    { 40, "Description for product 40", "Product 40", 172m },
                    { 41, "Description for product 41", "Product 41", 976m },
                    { 42, "Description for product 42", "Product 42", 316m },
                    { 43, "Description for product 43", "Product 43", 276m },
                    { 44, "Description for product 44", "Product 44", 867m },
                    { 45, "Description for product 45", "Product 45", 109m },
                    { 46, "Description for product 46", "Product 46", 941m },
                    { 47, "Description for product 47", "Product 47", 435m },
                    { 48, "Description for product 48", "Product 48", 660m },
                    { 49, "Description for product 49", "Product 49", 695m },
                    { 50, "Description for product 50", "Product 50", 733m },
                    { 51, "Description for product 51", "Product 51", 258m },
                    { 52, "Description for product 52", "Product 52", 776m },
                    { 53, "Description for product 53", "Product 53", 387m },
                    { 54, "Description for product 54", "Product 54", 786m },
                    { 55, "Description for product 55", "Product 55", 181m },
                    { 56, "Description for product 56", "Product 56", 280m },
                    { 57, "Description for product 57", "Product 57", 555m },
                    { 58, "Description for product 58", "Product 58", 600m },
                    { 59, "Description for product 59", "Product 59", 339m },
                    { 60, "Description for product 60", "Product 60", 165m },
                    { 61, "Description for product 61", "Product 61", 142m },
                    { 62, "Description for product 62", "Product 62", 983m },
                    { 63, "Description for product 63", "Product 63", 572m },
                    { 64, "Description for product 64", "Product 64", 962m },
                    { 65, "Description for product 65", "Product 65", 204m },
                    { 66, "Description for product 66", "Product 66", 694m },
                    { 67, "Description for product 67", "Product 67", 893m },
                    { 68, "Description for product 68", "Product 68", 753m },
                    { 69, "Description for product 69", "Product 69", 435m },
                    { 70, "Description for product 70", "Product 70", 969m },
                    { 71, "Description for product 71", "Product 71", 419m },
                    { 72, "Description for product 72", "Product 72", 838m },
                    { 73, "Description for product 73", "Product 73", 312m },
                    { 74, "Description for product 74", "Product 74", 190m },
                    { 75, "Description for product 75", "Product 75", 271m },
                    { 76, "Description for product 76", "Product 76", 204m },
                    { 77, "Description for product 77", "Product 77", 482m },
                    { 78, "Description for product 78", "Product 78", 139m },
                    { 79, "Description for product 79", "Product 79", 960m },
                    { 80, "Description for product 80", "Product 80", 190m },
                    { 81, "Description for product 81", "Product 81", 183m },
                    { 82, "Description for product 82", "Product 82", 341m },
                    { 83, "Description for product 83", "Product 83", 324m },
                    { 84, "Description for product 84", "Product 84", 302m },
                    { 85, "Description for product 85", "Product 85", 302m },
                    { 86, "Description for product 86", "Product 86", 284m },
                    { 87, "Description for product 87", "Product 87", 571m },
                    { 88, "Description for product 88", "Product 88", 612m },
                    { 89, "Description for product 89", "Product 89", 752m },
                    { 90, "Description for product 90", "Product 90", 469m },
                    { 91, "Description for product 91", "Product 91", 964m },
                    { 92, "Description for product 92", "Product 92", 547m },
                    { 93, "Description for product 93", "Product 93", 936m },
                    { 94, "Description for product 94", "Product 94", 525m },
                    { 95, "Description for product 95", "Product 95", 857m },
                    { 96, "Description for product 96", "Product 96", 504m },
                    { 97, "Description for product 97", "Product 97", 505m },
                    { 98, "Description for product 98", "Product 98", 211m },
                    { 99, "Description for product 99", "Product 99", 907m },
                    { 100, "Description for product 100", "Product 100", 365m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "ProductInStocks",
                columns: new[] { "Id", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 12 },
                    { 3, 3, 18 },
                    { 4, 4, 3 },
                    { 5, 5, 7 },
                    { 6, 6, 12 },
                    { 7, 7, 0 },
                    { 8, 8, 16 },
                    { 9, 9, 8 },
                    { 10, 10, 12 },
                    { 11, 11, 0 },
                    { 12, 12, 2 },
                    { 13, 13, 6 },
                    { 14, 14, 8 },
                    { 15, 15, 17 },
                    { 16, 16, 8 },
                    { 17, 17, 7 },
                    { 18, 18, 8 },
                    { 19, 19, 13 },
                    { 20, 20, 8 },
                    { 21, 21, 15 },
                    { 22, 22, 10 },
                    { 23, 23, 3 },
                    { 24, 24, 18 },
                    { 25, 25, 7 },
                    { 26, 26, 14 },
                    { 27, 27, 3 },
                    { 28, 28, 8 },
                    { 29, 29, 0 },
                    { 30, 30, 7 },
                    { 31, 31, 17 },
                    { 32, 32, 10 },
                    { 33, 33, 10 },
                    { 34, 34, 14 },
                    { 35, 35, 18 },
                    { 36, 36, 19 },
                    { 37, 37, 0 },
                    { 38, 38, 0 },
                    { 39, 39, 16 },
                    { 40, 40, 3 },
                    { 41, 41, 4 },
                    { 42, 42, 11 },
                    { 43, 43, 9 },
                    { 44, 44, 15 },
                    { 45, 45, 15 },
                    { 46, 46, 13 },
                    { 47, 47, 15 },
                    { 48, 48, 6 },
                    { 49, 49, 5 },
                    { 50, 50, 13 },
                    { 51, 51, 1 },
                    { 52, 52, 17 },
                    { 53, 53, 17 },
                    { 54, 54, 10 },
                    { 55, 55, 14 },
                    { 56, 56, 11 },
                    { 57, 57, 18 },
                    { 58, 58, 14 },
                    { 59, 59, 13 },
                    { 60, 60, 9 },
                    { 61, 61, 7 },
                    { 62, 62, 17 },
                    { 63, 63, 18 },
                    { 64, 64, 0 },
                    { 65, 65, 4 },
                    { 66, 66, 8 },
                    { 67, 67, 10 },
                    { 68, 68, 19 },
                    { 69, 69, 10 },
                    { 70, 70, 6 },
                    { 71, 71, 3 },
                    { 72, 72, 7 },
                    { 73, 73, 0 },
                    { 74, 74, 3 },
                    { 75, 75, 11 },
                    { 76, 76, 13 },
                    { 77, 77, 14 },
                    { 78, 78, 12 },
                    { 79, 79, 5 },
                    { 80, 80, 15 },
                    { 81, 81, 10 },
                    { 82, 82, 11 },
                    { 83, 83, 12 },
                    { 84, 84, 14 },
                    { 85, 85, 2 },
                    { 86, 86, 4 },
                    { 87, 87, 7 },
                    { 88, 88, 8 },
                    { 89, 89, 17 },
                    { 90, 90, 7 },
                    { 91, 91, 5 },
                    { 92, 92, 17 },
                    { 93, 93, 18 },
                    { 94, 94, 17 },
                    { 95, 95, 1 },
                    { 96, 96, 15 },
                    { 97, 97, 17 },
                    { 98, 98, 11 },
                    { 99, 99, 6 },
                    { 100, 100, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInStocks_ProductId",
                schema: "Catalog",
                table: "ProductInStocks",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInStocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
