using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zSolutions.Migrations
{
    public partial class UpdateJobsInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GitHub",
                table: "Jobs",
                newName: "Github");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Jobs",
                newName: "Create");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Github",
                table: "Jobs",
                newName: "GitHub");

            migrationBuilder.RenameColumn(
                name: "Create",
                table: "Jobs",
                newName: "DateCreated");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);
        }
    }
}
