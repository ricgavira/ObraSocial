using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObraSocial.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoNovasEstruturas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Classificacao",
                table: "PessoaFisica",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoutrinarioId",
                table: "Curso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Curso",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Situacao",
                table: "Curso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Espirito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Psicografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditoraId = table.Column<int>(type: "int", nullable: false),
                    AnoPublicacao = table.Column<int>(type: "int", nullable: false),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livro_PessoaJuridica_EditoraId",
                        column: x => x.EditoraId,
                        principalTable: "PessoaJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_DoutrinarioId",
                table: "Curso",
                column: "DoutrinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_EditoraId",
                table: "Livro",
                column: "EditoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Livro_DoutrinarioId",
                table: "Curso",
                column: "DoutrinarioId",
                principalTable: "Livro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Livro_DoutrinarioId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropIndex(
                name: "IX_Curso_DoutrinarioId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Classificacao",
                table: "PessoaFisica");

            migrationBuilder.DropColumn(
                name: "DoutrinarioId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Curso");
        }
    }
}
