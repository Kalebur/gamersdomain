using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gamersdomain.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Computers", "computers" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Keyboards", "keyboards" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Mice", "mice" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Headsets", "headsets" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Keyboards");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Mice");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CategoryName",
                value: "Headsets");
        }
    }
}
