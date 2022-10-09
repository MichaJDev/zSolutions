using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zSolutions.Migrations
{
    public partial class UpdateUserInDatabaseAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Invited",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Invited",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
