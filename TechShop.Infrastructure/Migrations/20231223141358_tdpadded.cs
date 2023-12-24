using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tdpadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TDP",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TDP",
                table: "CPUs");
        }
    }
}
