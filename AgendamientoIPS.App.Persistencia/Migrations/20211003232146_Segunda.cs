using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamientoIPS.App.Persistencia.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Sedes_UbicacionId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_UbicacionId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "UbicacionId",
                table: "Citas");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Hora",
                table: "Citas",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Ubicacion",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Citas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Hora",
                table: "Citas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<int>(
                name: "UbicacionId",
                table: "Citas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citas_UbicacionId",
                table: "Citas",
                column: "UbicacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Sedes_UbicacionId",
                table: "Citas",
                column: "UbicacionId",
                principalTable: "Sedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
