using Microsoft.EntityFrameworkCore.Migrations;

namespace Appka_CV_API.Migrations
{
    public partial class fourteenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Microsoft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Samsung" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Politechnika" });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Category", "City", "CompanyId", "Description", "FileName", "HR", "JobTitle", "Position", "SalaryFrom" },
                values: new object[,]
                {
                    { 1, "Programista", "Warszawa", 1, "Superancka oferta pracy dla seniora w .net", "22.jpg", "zrl67373@bcaoo.com", "Praca dla programisty", "Senior", "15000" },
                    { 4, "Programista", "Warszawa", 2, "Nudna praca dla programisty java", "22.jpg", "oob23573@zzrgg.com", "Praca dla developera java", "Mid", "5000" },
                    { 2, "Piekarz", "Zakopane", 3, "Superancka oferta pracy dla zdolnego piekarza (bułeczki oraz chlebki)", "22.jpg", "zrl67373@bcaoo.com", "Praca dla piekarza", "Praktyki", "2000" },
                    { 3, "Barman", "Warszawa", 3, "Superancka oferta pracy dla wybitnego barmana", "22.jpg", "oob23573@zzrgg.com", "Praca dla barmana", "Pełen etat", "5000" }
                });

            migrationBuilder.InsertData(
                table: "JobApplications",
                columns: new[] { "Id", "Accepted", "Address", "Education", "EmailAddress", "FileName", "FirstName", "Hobbies", "JobOfferId", "Languages", "LastName", "PhoneNumber", "Skills", "User" },
                values: new object[,]
                {
                    { 1, false, "Warszawa", "Średnie", "mailik@mailons.com", "03-01-2020-02-47-14.pdf", "Marian", "Latanie i pływanie", 1, "Polski i inne też umiem", "Kowalski", "919212517", "Umiem piec chleb i pisać dobry kod", "dmw57033@zzrgg.com" },
                    { 2, false, "Warszawa", "Wyższe", "mailik@mailons.com", "03-01-2020-02-47-14.pdf", "Krzysztof", "Latanie i pływanie", 1, "Polski i inne też umiem", "Rębacz", "919212517", "Umiem piec chleb i pisać dobry kod", "dmw57033@zzrgg.com" },
                    { 4, false, "Warszawa", "Średnie", "mailik@mailons.com", "03-01-2020-02-47-14.pdf", "Wiesiek", "Latanie i pływanie", 1, "Polski i inne też umiem", "Wojecki", "919212517", "Umiem piec chleb i pisać dobry kod", "d10052011@urhen.com" },
                    { 3, false, "Warszawa", "Średnie", "mailik@mailons.com", "03-01-2020-02-47-14.pdf", "Marian", "Latanie i pływanie", 2, "Polski i inne też umiem", "Kowalski", "919212517", "Umiem piec chleb i pisać dobry kod", "dmw57033@zzrgg.com" },
                    { 5, false, "Warszawa", "Średnie", "mailik@mailons.com", "03-01-2020-02-47-14.pdf", "Wiesiek", "Latanie i pływanie", 2, "Polski i inne też umiem", "Wojecki", "919212517", "Umiem piec chleb i pisać dobry kod", "zyw93775@bcaoo.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
