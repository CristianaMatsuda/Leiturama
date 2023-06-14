using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturama.Migrations
{
    public partial class GeneroMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GeneroId",
                table: "Artigo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Artigo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_CategoriaId",
                table: "Artigo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_GeneroId",
                table: "Artigo",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigo_Categoria_CategoriaId",
                table: "Artigo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigo_Genero_GeneroId",
                table: "Artigo",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigo_Categoria_CategoriaId",
                table: "Artigo");

            migrationBuilder.DropForeignKey(
                name: "FK_Artigo_Genero_GeneroId",
                table: "Artigo");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Artigo_CategoriaId",
                table: "Artigo");

            migrationBuilder.DropIndex(
                name: "IX_Artigo_GeneroId",
                table: "Artigo");

            migrationBuilder.AlterColumn<int>(
                name: "GeneroId",
                table: "Artigo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Artigo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
