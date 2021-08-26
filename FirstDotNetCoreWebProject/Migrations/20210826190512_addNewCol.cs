using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstDotNetCoreWebProject.Migrations
{
    public partial class addNewCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewC",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewC",
                table: "Students");
        }
    }
}
