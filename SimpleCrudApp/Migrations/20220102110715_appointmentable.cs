using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCrudApp.Migrations
{
    public partial class appointmentable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Patients",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "CityId",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
