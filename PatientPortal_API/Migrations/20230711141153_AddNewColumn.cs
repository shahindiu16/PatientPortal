using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientPortal_API.Migrations
{
    public partial class AddNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EpilepsyId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EpilepsyId",
                table: "Patients");
        }
    }
}
