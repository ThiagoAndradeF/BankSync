using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankSynce.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PES_CLIENTE",
                columns: table => new
                {
                    CD_CLIENTE = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_CLIENTE = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CD_USUARIO = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PES_CLIENTE", x => x.CD_CLIENTE);
                });

            migrationBuilder.CreateTable(
                name: "TAB_BANCO",
                columns: table => new
                {
                    CD_BANCO = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_BANCO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAB_BANCO", x => x.CD_BANCO);
                });

            migrationBuilder.CreateTable(
                name: "PES_FORNECEDOR",
                columns: table => new
                {
                    CD_FORNECEDOR = table.Column<int>(type: "integer", nullable: false),
                    CD_CLIENTE = table.Column<int>(type: "integer", nullable: false),
                    NM_FORNECEDOR = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PES_FORNECEDOR", x => x.CD_FORNECEDOR);
                    table.ForeignKey(
                        name: "FK_PES_FORNECEDOR_PES_CLIENTE_CD_FORNECEDOR",
                        column: x => x.CD_FORNECEDOR,
                        principalTable: "PES_CLIENTE",
                        principalColumn: "CD_CLIENTE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER_USUARIO",
                columns: table => new
                {
                    CD_USUARIO = table.Column<int>(type: "integer", nullable: false),
                    DS_EMAIL = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DS_SENHA = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DT_CADASTRO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CD_CLIENTE = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_USUARIO", x => x.CD_USUARIO);
                    table.ForeignKey(
                        name: "FK_USER_USUARIO_PES_CLIENTE_CD_USUARIO",
                        column: x => x.CD_USUARIO,
                        principalTable: "PES_CLIENTE",
                        principalColumn: "CD_CLIENTE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OCS_CONTA",
                columns: table => new
                {
                    CD_CONTA = table.Column<int>(type: "integer", nullable: false),
                    VL_SALDO = table.Column<decimal>(type: "numeric", nullable: false),
                    NR_CONTA = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    NR_AGENCIA = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DT_CADASTRO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CD_BANCO = table.Column<int>(type: "integer", nullable: false),
                    CD_CLIENTE = table.Column<int>(type: "integer", nullable: true),
                    CD_FORNECEDOR = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCS_CONTA", x => x.CD_CONTA);
                    table.ForeignKey(
                        name: "FK_OCS_CONTA_PES_CLIENTE_CD_CONTA",
                        column: x => x.CD_CONTA,
                        principalTable: "PES_CLIENTE",
                        principalColumn: "CD_CLIENTE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OCS_CONTA_PES_FORNECEDOR_CD_CONTA",
                        column: x => x.CD_CONTA,
                        principalTable: "PES_FORNECEDOR",
                        principalColumn: "CD_FORNECEDOR",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OCS_CONTA_TAB_BANCO_CD_CONTA",
                        column: x => x.CD_CONTA,
                        principalTable: "TAB_BANCO",
                        principalColumn: "CD_BANCO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OCS_TRANSACOES",
                columns: table => new
                {
                    CD_TRANSACAO = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CD_CONTA_ENTRADA = table.Column<int>(type: "integer", nullable: false),
                    CD_CONTA_SAIDA = table.Column<int>(type: "integer", nullable: false),
                    CD_CLIENTE = table.Column<int>(type: "integer", nullable: false),
                    CLIENTECD_CLIENTE = table.Column<int>(type: "integer", nullable: false),
                    CD_FORNECEDOR = table.Column<int>(type: "integer", nullable: false),
                    FORNECEDORCD_FORNECEDOR = table.Column<int>(type: "integer", nullable: false),
                    DT_TRANSACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DS_TRANSACAO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    VL_TRANSACAO = table.Column<int>(type: "integer", nullable: false),
                    ID_TRANSACAO = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCS_TRANSACOES", x => x.CD_TRANSACAO);
                    table.ForeignKey(
                        name: "FK_OCS_TRANSACOES_OCS_CONTA_CD_CONTA_ENTRADA",
                        column: x => x.CD_CONTA_ENTRADA,
                        principalTable: "OCS_CONTA",
                        principalColumn: "CD_CONTA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OCS_TRANSACOES_OCS_CONTA_CD_CONTA_SAIDA",
                        column: x => x.CD_CONTA_SAIDA,
                        principalTable: "OCS_CONTA",
                        principalColumn: "CD_CONTA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OCS_TRANSACOES_PES_CLIENTE_CLIENTECD_CLIENTE",
                        column: x => x.CLIENTECD_CLIENTE,
                        principalTable: "PES_CLIENTE",
                        principalColumn: "CD_CLIENTE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OCS_TRANSACOES_PES_FORNECEDOR_FORNECEDORCD_FORNECEDOR",
                        column: x => x.FORNECEDORCD_FORNECEDOR,
                        principalTable: "PES_FORNECEDOR",
                        principalColumn: "CD_FORNECEDOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OCS_TRANSACOES_CD_CONTA_ENTRADA",
                table: "OCS_TRANSACOES",
                column: "CD_CONTA_ENTRADA");

            migrationBuilder.CreateIndex(
                name: "IX_OCS_TRANSACOES_CD_CONTA_SAIDA",
                table: "OCS_TRANSACOES",
                column: "CD_CONTA_SAIDA");

            migrationBuilder.CreateIndex(
                name: "IX_OCS_TRANSACOES_CLIENTECD_CLIENTE",
                table: "OCS_TRANSACOES",
                column: "CLIENTECD_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_OCS_TRANSACOES_FORNECEDORCD_FORNECEDOR",
                table: "OCS_TRANSACOES",
                column: "FORNECEDORCD_FORNECEDOR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OCS_TRANSACOES");

            migrationBuilder.DropTable(
                name: "USER_USUARIO");

            migrationBuilder.DropTable(
                name: "OCS_CONTA");

            migrationBuilder.DropTable(
                name: "PES_FORNECEDOR");

            migrationBuilder.DropTable(
                name: "TAB_BANCO");

            migrationBuilder.DropTable(
                name: "PES_CLIENTE");
        }
    }
}
