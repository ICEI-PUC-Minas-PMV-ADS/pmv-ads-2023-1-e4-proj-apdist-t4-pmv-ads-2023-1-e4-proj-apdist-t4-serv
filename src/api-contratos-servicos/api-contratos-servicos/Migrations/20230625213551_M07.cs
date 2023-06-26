using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_contratos_servicos.Migrations
{
    /// <inheritdoc />
    public partial class M07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fornecedor",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "Pedido",
                table: "Orcamento");

            migrationBuilder.RenameColumn(
                name: "orcamentoAprovado",
                table: "Orcamento",
                newName: "Status");

            migrationBuilder.AlterColumn<double>(
                name: "ValorOrcamento",
                table: "Orcamento",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Orcamento",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Orcamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Orcamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FornecedorTipoServico",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    TipoServicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorTipoServico", x => new { x.FornecedorId, x.TipoServicoId });
                    table.ForeignKey(
                        name: "FK_FornecedorTipoServico_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FornecedorTipoServico_TipoServico_TipoServicoId",
                        column: x => x.TipoServicoId,
                        principalTable: "TipoServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_UsuarioId",
                table: "Orcamento",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorTipoServico_TipoServicoId",
                table: "FornecedorTipoServico",
                column: "TipoServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_usuarios_UsuarioId",
                table: "Orcamento",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_usuarios_UsuarioId",
                table: "Orcamento");

            migrationBuilder.DropTable(
                name: "FornecedorTipoServico");

            migrationBuilder.DropIndex(
                name: "IX_Orcamento_UsuarioId",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Orcamento");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orcamento",
                newName: "orcamentoAprovado");

            migrationBuilder.AlterColumn<string>(
                name: "ValorOrcamento",
                table: "Orcamento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "Orcamento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Fornecedor",
                table: "Orcamento",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pedido",
                table: "Orcamento",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
