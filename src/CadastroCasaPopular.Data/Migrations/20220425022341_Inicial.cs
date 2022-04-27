using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroCasaPopular.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Familias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Sobrenome = table.Column<string>(nullable: true),
                    Pai = table.Column<string>(nullable: true),
                    Mae = table.Column<string>(nullable: true),
                    RendaFamiliar = table.Column<decimal>(nullable: false),
                    Pontuacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filhos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    FamiliaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filhos_Familias_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filhos_FamiliaId",
                table: "Filhos",
                column: "FamiliaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filhos");

            migrationBuilder.DropTable(
                name: "Familias");
        }
    }
}
