using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Stocks_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Stocks",
                        principalColumn: "ProductInStockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 13 },
                    { 2, 2, 43 },
                    { 3, 3, 24 },
                    { 4, 4, 54 },
                    { 5, 5, 45 },
                    { 6, 6, 64 },
                    { 7, 7, 38 },
                    { 8, 8, 55 },
                    { 9, 9, 8 },
                    { 10, 10, 98 },
                    { 11, 11, 74 },
                    { 12, 12, 82 },
                    { 13, 13, 28 },
                    { 14, 14, 1 },
                    { 15, 15, 40 },
                    { 16, 16, 28 },
                    { 17, 17, 15 },
                    { 18, 18, 62 },
                    { 19, 19, 53 },
                    { 20, 20, 29 },
                    { 21, 21, 62 },
                    { 22, 22, 71 },
                    { 23, 23, 29 },
                    { 24, 24, 64 },
                    { 25, 25, 8 },
                    { 26, 26, 73 },
                    { 27, 27, 58 },
                    { 28, 28, 75 },
                    { 29, 29, 51 },
                    { 30, 30, 85 },
                    { 31, 31, 10 },
                    { 32, 32, 32 },
                    { 33, 33, 48 },
                    { 34, 34, 65 },
                    { 35, 35, 94 },
                    { 36, 36, 9 },
                    { 37, 37, 46 },
                    { 38, 38, 18 },
                    { 39, 39, 54 },
                    { 40, 40, 87 },
                    { 41, 41, 58 },
                    { 42, 42, 16 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 43, 43, 53 },
                    { 44, 44, 49 },
                    { 45, 45, 84 },
                    { 46, 46, 24 },
                    { 47, 47, 12 },
                    { 48, 48, 60 },
                    { 49, 49, 89 },
                    { 50, 50, 28 },
                    { 51, 51, 53 },
                    { 52, 52, 16 },
                    { 53, 53, 22 },
                    { 54, 54, 11 },
                    { 55, 55, 15 },
                    { 56, 56, 43 },
                    { 57, 57, 17 },
                    { 58, 58, 29 },
                    { 59, 59, 5 },
                    { 60, 60, 34 },
                    { 61, 61, 71 },
                    { 62, 62, 23 },
                    { 63, 63, 5 },
                    { 64, 64, 28 },
                    { 65, 65, 73 },
                    { 66, 66, 78 },
                    { 67, 67, 39 },
                    { 68, 68, 4 },
                    { 69, 69, 46 },
                    { 70, 70, 10 },
                    { 71, 71, 88 },
                    { 72, 72, 73 },
                    { 73, 73, 30 },
                    { 74, 74, 78 },
                    { 75, 75, 18 },
                    { 76, 76, 45 },
                    { 77, 77, 40 },
                    { 78, 78, 25 },
                    { 79, 79, 18 },
                    { 80, 80, 14 },
                    { 81, 81, 75 },
                    { 82, 82, 95 },
                    { 83, 83, 79 },
                    { 84, 84, 4 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 85, 85, 45 },
                    { 86, 86, 81 },
                    { 87, 87, 18 },
                    { 88, 88, 62 },
                    { 89, 89, 21 },
                    { 90, 90, 43 },
                    { 91, 91, 43 },
                    { 92, 92, 22 },
                    { 93, 93, 31 },
                    { 94, 94, 67 },
                    { 95, 95, 82 },
                    { 96, 96, 99 },
                    { 97, 97, 52 },
                    { 98, 98, 62 },
                    { 99, 99, 74 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 565m },
                    { 2, "Description for product 2", "Product 2", 168m },
                    { 3, "Description for product 3", "Product 3", 131m },
                    { 4, "Description for product 4", "Product 4", 992m },
                    { 5, "Description for product 5", "Product 5", 354m },
                    { 6, "Description for product 6", "Product 6", 200m },
                    { 7, "Description for product 7", "Product 7", 123m },
                    { 8, "Description for product 8", "Product 8", 650m },
                    { 9, "Description for product 9", "Product 9", 429m },
                    { 10, "Description for product 10", "Product 10", 337m },
                    { 11, "Description for product 11", "Product 11", 793m },
                    { 12, "Description for product 12", "Product 12", 182m },
                    { 13, "Description for product 13", "Product 13", 384m },
                    { 14, "Description for product 14", "Product 14", 173m },
                    { 15, "Description for product 15", "Product 15", 600m },
                    { 16, "Description for product 16", "Product 16", 897m },
                    { 17, "Description for product 17", "Product 17", 396m },
                    { 18, "Description for product 18", "Product 18", 954m },
                    { 19, "Description for product 19", "Product 19", 309m },
                    { 20, "Description for product 20", "Product 20", 292m },
                    { 21, "Description for product 21", "Product 21", 818m },
                    { 22, "Description for product 22", "Product 22", 410m },
                    { 23, "Description for product 23", "Product 23", 132m },
                    { 24, "Description for product 24", "Product 24", 747m },
                    { 25, "Description for product 25", "Product 25", 473m },
                    { 26, "Description for product 26", "Product 26", 174m },
                    { 27, "Description for product 27", "Product 27", 746m },
                    { 28, "Description for product 28", "Product 28", 391m },
                    { 29, "Description for product 29", "Product 29", 231m },
                    { 30, "Description for product 30", "Product 30", 291m },
                    { 31, "Description for product 31", "Product 31", 676m },
                    { 32, "Description for product 32", "Product 32", 809m },
                    { 33, "Description for product 33", "Product 33", 769m },
                    { 34, "Description for product 34", "Product 34", 595m },
                    { 35, "Description for product 35", "Product 35", 386m },
                    { 36, "Description for product 36", "Product 36", 452m },
                    { 37, "Description for product 37", "Product 37", 153m },
                    { 38, "Description for product 38", "Product 38", 670m },
                    { 39, "Description for product 39", "Product 39", 452m },
                    { 40, "Description for product 40", "Product 40", 731m },
                    { 41, "Description for product 41", "Product 41", 201m },
                    { 42, "Description for product 42", "Product 42", 350m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 43, "Description for product 43", "Product 43", 339m },
                    { 44, "Description for product 44", "Product 44", 791m },
                    { 45, "Description for product 45", "Product 45", 721m },
                    { 46, "Description for product 46", "Product 46", 121m },
                    { 47, "Description for product 47", "Product 47", 245m },
                    { 48, "Description for product 48", "Product 48", 277m },
                    { 49, "Description for product 49", "Product 49", 506m },
                    { 50, "Description for product 50", "Product 50", 972m },
                    { 51, "Description for product 51", "Product 51", 724m },
                    { 52, "Description for product 52", "Product 52", 676m },
                    { 53, "Description for product 53", "Product 53", 677m },
                    { 54, "Description for product 54", "Product 54", 500m },
                    { 55, "Description for product 55", "Product 55", 894m },
                    { 56, "Description for product 56", "Product 56", 728m },
                    { 57, "Description for product 57", "Product 57", 344m },
                    { 58, "Description for product 58", "Product 58", 556m },
                    { 59, "Description for product 59", "Product 59", 666m },
                    { 60, "Description for product 60", "Product 60", 522m },
                    { 61, "Description for product 61", "Product 61", 469m },
                    { 62, "Description for product 62", "Product 62", 136m },
                    { 63, "Description for product 63", "Product 63", 125m },
                    { 64, "Description for product 64", "Product 64", 329m },
                    { 65, "Description for product 65", "Product 65", 286m },
                    { 66, "Description for product 66", "Product 66", 153m },
                    { 67, "Description for product 67", "Product 67", 999m },
                    { 68, "Description for product 68", "Product 68", 538m },
                    { 69, "Description for product 69", "Product 69", 371m },
                    { 70, "Description for product 70", "Product 70", 627m },
                    { 71, "Description for product 71", "Product 71", 106m },
                    { 72, "Description for product 72", "Product 72", 102m },
                    { 73, "Description for product 73", "Product 73", 204m },
                    { 74, "Description for product 74", "Product 74", 797m },
                    { 75, "Description for product 75", "Product 75", 490m },
                    { 76, "Description for product 76", "Product 76", 846m },
                    { 77, "Description for product 77", "Product 77", 910m },
                    { 78, "Description for product 78", "Product 78", 892m },
                    { 79, "Description for product 79", "Product 79", 391m },
                    { 80, "Description for product 80", "Product 80", 507m },
                    { 81, "Description for product 81", "Product 81", 388m },
                    { 82, "Description for product 82", "Product 82", 137m },
                    { 83, "Description for product 83", "Product 83", 401m },
                    { 84, "Description for product 84", "Product 84", 377m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 85, "Description for product 85", "Product 85", 725m },
                    { 86, "Description for product 86", "Product 86", 458m },
                    { 87, "Description for product 87", "Product 87", 920m },
                    { 88, "Description for product 88", "Product 88", 761m },
                    { 89, "Description for product 89", "Product 89", 839m },
                    { 90, "Description for product 90", "Product 90", 211m },
                    { 91, "Description for product 91", "Product 91", 648m },
                    { 92, "Description for product 92", "Product 92", 751m },
                    { 93, "Description for product 93", "Product 93", 854m },
                    { 94, "Description for product 94", "Product 94", 214m },
                    { 95, "Description for product 95", "Product 95", 160m },
                    { 96, "Description for product 96", "Product 96", 482m },
                    { 97, "Description for product 97", "Product 97", 646m },
                    { 98, "Description for product 98", "Product 98", 638m },
                    { 99, "Description for product 99", "Product 99", 387m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");
        }
    }
}
