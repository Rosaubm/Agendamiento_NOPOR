using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamientoIPS.App.Persistencia.Migrations
{
    public partial class Sexta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdConvenioId",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_IdConvenioId",
                table: "Facturas",
                column: "IdConvenioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Convenios_IdConvenioId",
                table: "Facturas",
                column: "IdConvenioId",
                principalTable: "Convenios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Convenios_IdConvenioId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_IdConvenioId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "IdConvenioId",
                table: "Facturas");
        }
    }
}
