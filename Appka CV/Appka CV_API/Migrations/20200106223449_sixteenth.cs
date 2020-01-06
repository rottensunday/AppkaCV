using Microsoft.EntityFrameworkCore.Migrations;

namespace Appka_CV_API.Migrations
{
    public partial class sixteenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileName",
                value: "Rysunek12344.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "Rysunek12344.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileName",
                value: "Rysunek12344.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileName",
                value: "Rysunek12344.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "FileName",
                value: "Rysunek12344.pdf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileName",
                value: "03-01-2020-02-47-14.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "03-01-2020-02-47-14.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileName",
                value: "03-01-2020-02-47-14.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileName",
                value: "03-01-2020-02-47-14.pdf");

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 5,
                column: "FileName",
                value: "03-01-2020-02-47-14.pdf");
        }
    }
}
