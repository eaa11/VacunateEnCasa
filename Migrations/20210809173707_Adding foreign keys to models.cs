using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea9._0.Migrations
{
    public partial class Addingforeignkeystomodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Provincias_ProvinciaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Sangres_SangreId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_ProvinciaId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_SangreId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "SangreId",
                table: "Personas");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdProvincia",
                table: "Personas",
                column: "IdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdSangre",
                table: "Personas",
                column: "IdSangre");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Provincias_IdProvincia",
                table: "Personas",
                column: "IdProvincia",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Sangres_IdSangre",
                table: "Personas",
                column: "IdSangre",
                principalTable: "Sangres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Provincias_IdProvincia",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Sangres_IdSangre",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_IdProvincia",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_IdSangre",
                table: "Personas");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Provincias",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProvinciaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SangreId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ProvinciaId",
                table: "Personas",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_SangreId",
                table: "Personas",
                column: "SangreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Provincias_ProvinciaId",
                table: "Personas",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Sangres_SangreId",
                table: "Personas",
                column: "SangreId",
                principalTable: "Sangres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
