using Microsoft.EntityFrameworkCore.Migrations;

namespace Car4U.Infrastructure.Migrations
{
    public partial class removecategorycarfamily : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarFamily",
                table: "PostCategories");

            migrationBuilder.AddColumn<string>(
                name: "CarFamily",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarFamily",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "CarFamily",
                table: "PostCategories",
                maxLength: 50,
                nullable: true);
        }
    }
}
