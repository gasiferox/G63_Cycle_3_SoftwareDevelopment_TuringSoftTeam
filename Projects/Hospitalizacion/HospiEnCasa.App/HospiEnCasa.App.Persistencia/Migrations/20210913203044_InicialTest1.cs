using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class InicialTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnfermeraId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especialidad",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamiliarDesignadoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaNacimiento",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoriaClinicaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Latitud",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitud",
                table: "Personas",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parentesco",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlanMedico",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistroMedico",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Personas",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FechaHora = table.Column<DateTime>(type: "datetime", nullable: false),
                    TipoSigno = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<float>(type: "float", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignosVitales_Personas_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tratamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Recomendaciones = table.Column<string>(type: "text", nullable: true),
                    Incapacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FechaAtencion = table.Column<string>(type: "text", nullable: true),
                    Antecedentes = table.Column<string>(type: "text", nullable: true),
                    TratamientoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoriasClinicas_Tratamientos_TratamientoId",
                        column: x => x.TratamientoId,
                        principalTable: "Tratamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NombreMedicamento = table.Column<int>(type: "int", nullable: false),
                    Posologia = table.Column<string>(type: "text", nullable: true),
                    TratamientoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicamentos_Tratamientos_TratamientoId",
                        column: x => x.TratamientoId,
                        principalTable: "Tratamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Remisiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TipoExamen = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime", nullable: false),
                    Resultado = table.Column<string>(type: "text", nullable: true),
                    TratamientoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remisiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remisiones_Tratamientos_TratamientoId",
                        column: x => x.TratamientoId,
                        principalTable: "Tratamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_FamiliarDesignadoId",
                table: "Personas",
                column: "FamiliarDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistoriaClinicaId",
                table: "Personas",
                column: "HistoriaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_TratamientoId",
                table: "HistoriasClinicas",
                column: "TratamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_TratamientoId",
                table: "Medicamentos",
                column: "TratamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_TratamientoId",
                table: "Remisiones",
                column: "TratamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_PacienteId",
                table: "SignosVitales",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_HistoriasClinicas_HistoriaClinicaId",
                table: "Personas",
                column: "HistoriaClinicaId",
                principalTable: "HistoriasClinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_FamiliarDesignadoId",
                table: "Personas",
                column: "FamiliarDesignadoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_HistoriasClinicas_HistoriaClinicaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Remisiones");

            migrationBuilder.DropTable(
                name: "SignosVitales");

            migrationBuilder.DropTable(
                name: "Tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_HistoriaClinicaId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_MedicoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EnfermeraId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HistoriaClinicaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Parentesco",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PlanMedico",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RegistroMedico",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Personas");
        }
    }
}
