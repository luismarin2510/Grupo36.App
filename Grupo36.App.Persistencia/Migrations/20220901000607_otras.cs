using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grupo36.App.Persistencia.Migrations
{
    public partial class otras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "edad",
                table: "personas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apellido",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "edad",
                table: "personas");
        }
    }
}
