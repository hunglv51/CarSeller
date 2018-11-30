using Microsoft.EntityFrameworkCore.Migrations;

namespace Car4U.Infrastructure.Migrations
{
    public partial class changeuseraddressfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AppUser",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "AppUser",
                newName: "Address");
        }
    }
}
