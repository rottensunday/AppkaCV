using Microsoft.EntityFrameworkCore.Migrations;

namespace Appka_CV_API.Migrations
{
    public partial class tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "JobOffers");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "JobOffers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "JobOffers");

            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "JobOffers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
