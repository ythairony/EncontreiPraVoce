using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEncontreiPraVoce.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ImagemItemUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeUsuario = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SenhaHash = table.Column<string>(type: "TEXT", nullable: false),
                    NomeCompleto = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TelefoneContato = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcheiNaRuaPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeProduto = table.Column<string>(type: "TEXT", nullable: false),
                    LocalEncontrado = table.Column<string>(type: "TEXT", nullable: false),
                    DataEncontrado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataPostagem = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcheiNaRuaPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcheiNaRuaPosts_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcheiNaRuaPosts_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerdiNaRuaPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeItem = table.Column<string>(type: "TEXT", nullable: false),
                    FotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    LocalPerdido = table.Column<string>(type: "TEXT", nullable: false),
                    TelefoneContato = table.Column<string>(type: "TEXT", nullable: false),
                    DataPostagem = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerdiNaRuaPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerdiNaRuaPosts_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerguntasConfirmacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pergunta = table.Column<string>(type: "TEXT", nullable: false),
                    AcheiNaRuaPostId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntasConfirmacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerguntasConfirmacao_AcheiNaRuaPosts_AcheiNaRuaPostId",
                        column: x => x.AcheiNaRuaPostId,
                        principalTable: "AcheiNaRuaPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpcoesResposta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Texto = table.Column<string>(type: "TEXT", nullable: false),
                    EhCorreta = table.Column<bool>(type: "INTEGER", nullable: false),
                    PerguntaConfirmacaoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcoesResposta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpcoesResposta_PerguntasConfirmacao_PerguntaConfirmacaoId",
                        column: x => x.PerguntaConfirmacaoId,
                        principalTable: "PerguntasConfirmacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcheiNaRuaPosts_CategoriaId",
                table: "AcheiNaRuaPosts",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_AcheiNaRuaPosts_UsuarioId",
                table: "AcheiNaRuaPosts",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcoesResposta_PerguntaConfirmacaoId",
                table: "OpcoesResposta",
                column: "PerguntaConfirmacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PerdiNaRuaPosts_UsuarioId",
                table: "PerdiNaRuaPosts",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasConfirmacao_AcheiNaRuaPostId",
                table: "PerguntasConfirmacao",
                column: "AcheiNaRuaPostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpcoesResposta");

            migrationBuilder.DropTable(
                name: "PerdiNaRuaPosts");

            migrationBuilder.DropTable(
                name: "PerguntasConfirmacao");

            migrationBuilder.DropTable(
                name: "AcheiNaRuaPosts");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
