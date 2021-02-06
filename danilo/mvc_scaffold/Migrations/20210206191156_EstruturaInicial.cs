using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace mvc_scaffold.Migrations
{
    public partial class EstruturaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    client_nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CPF = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    Endereco = table.Column<string>(type: "Text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_client", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_client");
        }
    }
}
