using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamientoIPS.App.Persistencia.Migrations
{
    public partial class Quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturaciones");

            migrationBuilder.CreateTable(
                name: "Facturas",
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
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Citas_CitaId",
                        column: x => x.CitaId,
                        principalTable: "Citas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_CitaId",
                table: "Facturas",
                column: "CitaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.CreateTable(
                name: "Facturaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitaId = table.Column<int>(type: "int", nullable: true),
                    Concepto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaFactura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormadePago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumFactura = table.Column<int>(type: "int", nullable: false),
                    TarifaAplicada = table.Column<int>(type: "int", nullable: false),
                    ValorPagado = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_Facturaciones_CitaId",
                table: "Facturaciones",
                column: "CitaId");
        }
    }
}
