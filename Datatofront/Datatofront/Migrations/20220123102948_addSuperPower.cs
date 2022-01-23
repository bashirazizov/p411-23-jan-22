using Microsoft.EntityFrameworkCore.Migrations;

namespace Datatofront.Migrations
{
    public partial class addSuperPower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Superpower",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Superpower",
                table: "Students");
        }
    }
}
