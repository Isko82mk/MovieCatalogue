using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class updatemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "FirstName", "LastName", "Role" },
                values: new object[] { 4, "Arnold", "Schwarzenegger", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "FirstName", "LastName", "Role" },
                values: new object[] { 5, "Michael ", "Keaton", 0 });

            migrationBuilder.InsertData(
                table: "MoviePersons",
                columns: new[] { "MovieId", "PersonId", "Id" },
                values: new object[] { 2, 4, 2 });

            migrationBuilder.InsertData(
                table: "MoviePersons",
                columns: new[] { "MovieId", "PersonId", "Id" },
                values: new object[] { 3, 5, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MoviePersons",
                keyColumns: new[] { "MovieId", "PersonId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "MoviePersons",
                keyColumns: new[] { "MovieId", "PersonId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
