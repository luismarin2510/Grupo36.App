using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grupo36.App.Persistencia.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "telefono",
                table: "personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "telefono",
                table: "personas");
        }
    }
}
