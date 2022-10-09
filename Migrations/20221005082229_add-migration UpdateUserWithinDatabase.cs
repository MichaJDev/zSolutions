using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zSolutions.Migrations
{
    public partial class addmigrationUpdateUserWithinDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surename",
                table: "Users",
                newName: "Surname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "Surename");
        }
    }
}
