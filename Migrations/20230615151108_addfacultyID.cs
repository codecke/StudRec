using Microsoft.EntityFrameworkCore.Migrations;

namespace StudRec.Migrations
{
    public partial class addfacultyID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultyID",
                table: "dbmajors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "dbmajors");
        }
    }
}
