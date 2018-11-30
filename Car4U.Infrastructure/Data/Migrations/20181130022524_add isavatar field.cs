using Microsoft.EntityFrameworkCore.Migrations;

namespace Car4U.Infrastructure.Migrations
{
    public partial class addisavatarfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "CarImages");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvatar",
                table: "CarImages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvatar",
                table: "CarImages");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "CarImages",
                nullable: false,
                defaultValue: 0);
        }
    }
}
