using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace at_test.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    NomeImagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, "Areia lavada Saco 1KG", "Areia Lavada Saco 1KG", "areia.png", 2.9f, 500 },
                    { 2, "Saco cimento votoram 25KG", "Cimento Votoram 25KG", "cimento_votoram.png", 27.9f, 300 },
                    { 3, "Tijolo Tradicional", "Tijolo Tradicional", "tijolo.png", 4.9f, 400 },
                    { 4, "Tubo Esgoto PVC Série Normal 6M", "Tubo Esgoto PVC Série Normal 6M", "tubo_esgoto_pvc_6m.png", 5.9f, 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
