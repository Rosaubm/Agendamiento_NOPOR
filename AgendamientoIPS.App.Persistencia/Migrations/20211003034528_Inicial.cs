using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamientoIPS.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Convenios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumConvenio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPS = table.Column<int>(type: "int", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Encuestas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntecedentesMedicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotivoConsulta = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuestas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreSede = table.Column<int>(type: "int", nullable: false),
                    HorarioAtencion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPS = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EncuestaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Encuestas_EncuestaId",
                        column: x => x.EncuestaId,
                        principalTable: "Encuestas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCita = table.Column<int>(type: "int", nullable: false),
                    NumCita = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMedicoId = table.Column<int>(type: "int", nullable: true),
                    IdPacienteId = table.Column<int>(type: "int", nullable: true),
                    UbicacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citas_Personas_IdMedicoId",
                        column: x => x.IdMedicoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Personas_IdPacienteId",
                        column: x => x.IdPacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Sedes_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitaId = table.Column<int>(type: "int", nullable: true),
                    NumFactura = table.Column<int>(type: "int", nullable: false),
                    FechaFactura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarifaAplicada = table.Column<int>(type: "int", nullable: false),
                    ValorPagado = table.Column<int>(type: "int", nullable: false),
                    FormadePago = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturaciones_Citas_CitaId",
                        column: x => x.CitaId,
                        principalTable: "Citas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdMedicoId",
                table: "Citas",
                column: "IdMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdPacienteId",
                table: "Citas",
                column: "IdPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_UbicacionId",
                table: "Citas",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_CitaId",
                table: "Facturaciones",
                column: "CitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EncuestaId",
                table: "Personas",
                column: "EncuestaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Convenios");

            migrationBuilder.DropTable(
                name: "Facturaciones");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropTable(
                name: "Encuestas");
        }
    }
}
