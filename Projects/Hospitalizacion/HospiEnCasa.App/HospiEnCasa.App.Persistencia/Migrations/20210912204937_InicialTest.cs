using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class InicialTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "HorasLaborales",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TarjetaProfesional",
                table: "Personas",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HorasLaborales",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TarjetaProfesional",
                table: "Personas");
        }
    }
}
