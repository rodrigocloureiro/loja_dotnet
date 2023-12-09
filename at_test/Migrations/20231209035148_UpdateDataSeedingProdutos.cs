using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace at_test.Migrations
{
    public partial class UpdateDataSeedingProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "DataRegistro", "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 7, 29, 15, 36, 12, 0, DateTimeKind.Unspecified), "Camisa Vasco Branca III (Edição Especial) 2022/2023 – Versão Torcedor", "Camisa Vasco Branca III 2022/2023", "camisa_vasco_III.png", 359.90m, 500 },
                    { 11, new DateTime(2022, 7, 29, 15, 36, 12, 0, DateTimeKind.Unspecified), "Camisa Vasco Preta III (Goleiro - Edição Especial) 2022/2023 – Todos os Patrocinadores – Versão Torcedor", "Camisa Vasco Preta III (Goleiro) 2022/2023", "camisa_vasco_III_goleiro.png", 359.90m, 450 },
                    { 12, new DateTime(2023, 9, 25, 11, 17, 25, 0, DateTimeKind.Unspecified), "Camisa Vasco III Branco – (Goleiro) 2023/2024 – Versão Torcedor", "Camisa Vasco III Branco – (Goleiro) 2023/2024", "camisa_vasco_branco_goleiro_2023_2024.png", 329.90m, 300 },
                    { 13, new DateTime(2023, 7, 12, 13, 34, 46, 0, DateTimeKind.Unspecified), "Camisa Vasco Azul Claro – (Goleiro) 2023/2024 – Versão Torcedor", "Camisa Vasco Azul Claro – (Goleiro) 2023/2024", "camisa_vasco_goleiro_azul_claro_2023_2024.png", 299.90m, 390 },
                    { 14, new DateTime(2023, 8, 15, 10, 0, 5, 0, DateTimeKind.Unspecified), "Camisa Al Nassr Home 2023/2024 – Versão Torcedor", "Camisa Al Nassr Home 2023/2024", "camisa_al_nassr_home_2023_2024.png", 299.90m, 100 },
                    { 15, new DateTime(2023, 8, 15, 10, 0, 5, 0, DateTimeKind.Unspecified), "Camisa Al Nassr Away 2023/2024 – Versão Torcedor", "Camisa Al Nassr Away 2023/2024", "camisa_al_nassr_away_2023_2024.png", 299.90m, 70 },
                    { 16, new DateTime(2023, 8, 15, 10, 30, 5, 0, DateTimeKind.Unspecified), "Camisa Benfica Away 2023/2024 – Versão Torcedor", "Camisa Benfica Away 2023/2024", "camisa_benfica_away_2023_2024.png", 299.90m, 90 },
                    { 17, new DateTime(2023, 9, 17, 17, 2, 25, 0, DateTimeKind.Unspecified), "Camisa Manchester United (Goleiro) 2023/2024 Verde – Versão Torcedor", "Camisa Manchester United Verde (Goleiro) 2023/2024", "camisa_manchester_united_goleiro_2023_2024_verde.png", 299.90m, 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "DataRegistro", "Descricao", "Nome", "NomeImagem", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Vasco Branca III (Edição Especial) 2022/2023 – Versão Torcedor", "Camisa Vasco Branca III 2022/2023", "camisa_vasco_III", 359.90m, 500 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Vasco Preta III (Goleiro - Edição Especial) 2022/2023 – Todos os Patrocinadores – Versão Torcedor", "Camisa Vasco Preta III (Goleiro) 2022/2023", "camisa_vasco_III_goleiro", 359.90m, 450 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Vasco III Branco – (Goleiro) 2023/2024 – Versão Torcedor", "Camisa Vasco III Branco – (Goleiro) 2023/2024", "camisa_vasco_branco_goleiro_2023_2024", 329.90m, 300 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Vasco Azul Claro – (Goleiro) 2023/2024 – Versão Torcedor", "Camisa Vasco Azul Claro – (Goleiro) 2023/2024", "camisa_vasco_goleiro_azul_claro_2023_2024", 299.90m, 390 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Al Nassr Home 2023/2024 – Versão Torcedor", "Camisa Al Nassr Home 2023/2024", "camisa_al_nassr_home_2023_2024", 299.90m, 100 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Al Nassr Away 2023/2024 – Versão Torcedor", "Camisa Al Nassr Away 2023/2024", "camisa_al_nassr_away_2023_2024", 299.90m, 70 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Benfica Away 2023/2024 – Versão Torcedor", "Camisa Benfica Away 2023/2024", "camisa_benfica_away_2023_2024", 299.90m, 90 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camisa Manchester United (Goleiro) 2023/2024 Verde – Versão Torcedor", "Camisa Manchester United Verde (Goleiro) 2023/2024", "camisa_manchester_united_goleiro_2023_2024_verde", 299.90m, 50 }
                });
        }
    }
}
