using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class InicialTest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEnfermera",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdFamiliarDesignado",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdMedico",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Personas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEnfermera",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFamiliarDesignado",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMedico",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPaciente",
                table: "Personas",
                type: "int",
                nullable: true);
        }
    }
}
