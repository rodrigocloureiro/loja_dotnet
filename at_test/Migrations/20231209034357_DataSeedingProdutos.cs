using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace at_test.Migrations
{
    public partial class DataSeedingProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco" },
                values: new object[] { "Camisa Vasco Branca III (Edição Especial) 2022/2023 – Versão Torcedor", "Camisa Vasco Branca III 2022/2023", "camisa_vasco_III", 359.90m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[] { "Camisa Vasco Preta III (Goleiro - Edição Especial) 2022/2023 – Todos os Patrocinadores – Versão Torcedor", "Camisa Vasco Preta III (Goleiro) 2022/2023", "camisa_vasco_III_goleiro", 359.90m, 450 });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[] { "Camisa Vasco III Branco – (Goleiro) 2023/2024 – Versão Torcedor", "Camisa Vasco III Branco – (Goleiro) 2023/2024", "camisa_vasco_branco_goleiro_2023_2024", 329.90m, 300 });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[] { "Camisa Vasco Azul Claro – (Goleiro) 2023/2024 – Versão Torcedor", "Camisa Vasco Azul Claro – (Goleiro) 2023/2024", "camisa_vasco_goleiro_azul_claro_2023_2024", 299.90m, 390 });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "DataRegistro", "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Al Nassr Home 2023/2024 – Versão Torcedor", "Camisa Al Nassr Home 2023/2024", "camisa_al_nassr_home_2023_2024", 299.90m, 100 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Al Nassr Away 2023/2024 – Versão Torcedor", "Camisa Al Nassr Away 2023/2024", "camisa_al_nassr_away_2023_2024", 299.90m, 70 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Benfica Away 2023/2024 – Versão Torcedor", "Camisa Benfica Away 2023/2024", "camisa_benfica_away_2023_2024", 299.90m, 90 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Manchester United (Goleiro) 2023/2024 Verde – Versão Torcedor", "Camisa Manchester United Verde (Goleiro) 2023/2024", "camisa_manchester_united_goleiro_2023_2024_verde", 299.90m, 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco" },
                values: new object[] { "Areia lavada Saco 1KG", "Areia Lavada Saco 1KG", "areia.png", 2.90m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[] { "Saco cimento votoram 25KG", "Cimento Votoram 25KG", "cimento_votoram.png", 27.90m, 300 });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[] { "Tijolo Tradicional", "Tijolo Tradicional", "tijolo.png", 4.90m, 400 });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[] { "Tubo Esgoto PVC Série Normal 6M", "Tubo Esgoto PVC Série Normal 6M", "tubo_esgoto_pvc_6m.png", 5.90m, 100 });
        }
    }
}
