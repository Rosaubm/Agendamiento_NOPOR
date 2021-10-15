using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamientoIPS.App.Persistencia.Migrations
{
    public partial class Cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Citas");

            migrationBuilder.AddColumn<int>(
                name: "Ubicacion",
                table: "Sedes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSedeId",
                table: "Citas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdSedeId",
                table: "Citas",
                column: "IdSedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Sedes_IdSedeId",
                table: "Citas",
                column: "IdSedeId",
                principalTable: "Sedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Sedes_IdSedeId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_IdSedeId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Sedes");

            migrationBuilder.DropColumn(
                name: "IdSedeId",
                table: "Citas");

            migrationBuilder.AddColumn<int>(
                name: "Ubicacion",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
