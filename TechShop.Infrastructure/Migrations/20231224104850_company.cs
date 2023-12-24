using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class company : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Screens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "PCs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Laptops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "GPUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Gaming",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Screens");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Gaming");
        }
    }
}
