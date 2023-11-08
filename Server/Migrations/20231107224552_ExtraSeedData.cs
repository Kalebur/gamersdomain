using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gamersdomain.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExtraSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/mice/m1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/headsets/hs1.png");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "IsFeaturedProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 3, "Test Product #4! The fourth finest product known to man!", "/images/keyboards/kb1.png", false, "Test Product #4", 74.99m },
                    { 5, 1, "An incredibly powerful gaming system!", "/images/computers/comp2.png", false, "Test Product #5", 2499.99m },
                    { 6, 1, "An incredibly powerful gaming system!", "/images/computers/comp3.png", false, "Test Product #6", 3299.99m },
                    { 7, 1, "An incredibly powerful gaming system!", "/images/computers/comp4.png", false, "Test Product #7", 999.99m },
                    { 8, 2, "A stylish mouse for all your gaming needs!", "/images/mice/m2.png", false, "Test Product #8", 49.99m },
                    { 9, 2, "A stylish mouse for all your gaming needs!", "/images/mice/m3.png", false, "Test Product #9", 69.99m },
                    { 10, 2, "A stylish mouse for all your gaming needs!", "/images/mice/m4.png", false, "Test Product #10", 119.99m },
                    { 11, 3, "A stylish keyboard for all your gaming needs!", "/images/keyboards/kb2.png", false, "Test Product #11", 49.99m },
                    { 12, 3, "A stylish keyboard for all your gaming needs!", "/images/keyboards/kb3.png", false, "Test Product #12", 219.99m },
                    { 13, 3, "A stylish keyboard for all your gaming needs!", "/images/keyboards/kb4.png", false, "Test Product #13", 19.99m },
                    { 14, 4, "A stylish headset for all your gaming needs!", "/images/headsets/hs2.png", false, "Test Product #14", 49.99m },
                    { 15, 4, "A stylish headset for all your gaming needs!", "/images/headsets/hs3.png", false, "Test Product #15", 199.99m },
                    { 16, 4, "A stylish headset for all your gaming needs!", "/images/headsets/hs4.png", false, "Test Product #16", 249.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/mice/m3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/headsets/hs6.png");
        }
    }
}
