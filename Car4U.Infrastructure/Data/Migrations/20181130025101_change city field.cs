using Microsoft.EntityFrameworkCore.Migrations;

namespace Car4U.Infrastructure.Migrations
{
    public partial class changecityfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AppUser");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AppUser",
                nullable: true);
        }
    }
}
