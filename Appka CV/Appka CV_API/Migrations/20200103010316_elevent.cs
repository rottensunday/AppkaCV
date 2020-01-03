using Microsoft.EntityFrameworkCore.Migrations;

namespace Appka_CV_API.Migrations
{
    public partial class elevent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstFile",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "SecondFile",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "ThirdFile",
                table: "JobApplications");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "JobApplications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "JobApplications");

            migrationBuilder.AddColumn<string>(
                name: "FirstFile",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondFile",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFile",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
