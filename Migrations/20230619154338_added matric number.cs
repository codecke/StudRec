using Microsoft.EntityFrameworkCore.Migrations;

namespace StudRec.Migrations
{
    public partial class addedmatricnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MatNo",
                table: "dbStudInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatNo",
                table: "dbStudInfo");
        }
    }
}
