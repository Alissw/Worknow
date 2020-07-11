using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Worknow.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autonomos",
                columns: table => new
                {
                    AutonomoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    DatadeNascimento = table.Column<string>(nullable: false),
                    ServicosPrestados = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autonomos", x => x.AutonomoId);
                });

            migrationBuilder.CreateTable(
                name: "Empreendedores",
                columns: table => new
                {
                    MeiId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(nullable: false),
                    NomeFantasia = table.Column<string>(nullable: false),
                    Cnpj = table.Column<string>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    ConfirmarSenha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empreendedores", x => x.MeiId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autonomos");

            migrationBuilder.DropTable(
                name: "Empreendedores");
        }
    }
}
