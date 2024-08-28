using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstruturaDoProduto.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CodigoProdutoFornecedor = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustoPadrao = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    PrecoFinal = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    MargemDeLucroEmReais = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    PesoLiquido = table.Column<decimal>(type: "decimal(8,3)", nullable: true),
                    PesoBruto = table.Column<decimal>(type: "decimal(8,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
