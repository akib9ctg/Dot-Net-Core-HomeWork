using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstDotNetCoreWebProject.Migrations
{
    public partial class add_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DOB", "Department", "FirstName", "ImagePath", "LastName", "StudentId" },
                values: new object[] { 1, null, "CSE", "AKIB", null, null, "C151006" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DOB", "Department", "FirstName", "ImagePath", "LastName", "StudentId" },
                values: new object[] { 2, null, "EEE", "AKIB2", null, null, "C151016" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
