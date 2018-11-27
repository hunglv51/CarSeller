using Microsoft.EntityFrameworkCore.Migrations;

namespace Car4U.Infrastructure.Migrations
{
    public partial class addlogourl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "PostCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "PostCategories");
        }
    }
}
