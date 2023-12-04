using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace at_test.Migrations
{
    public partial class DataSeedingCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClienteModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ClienteModel",
                columns: new[] { "Id", "Cpf", "DataCadastro", "DataNascimento", "Nome" },
                values: new object[,]
                {
                    { 1, "41741808065", new DateTime(2022, 7, 29, 15, 36, 12, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 5, 5, 46, 32, 0, DateTimeKind.Unspecified), "Marcos Ramos" },
                    { 2, "66639368080", new DateTime(2021, 3, 2, 21, 12, 19, 0, DateTimeKind.Unspecified), new DateTime(1987, 10, 7, 9, 26, 36, 0, DateTimeKind.Unspecified), "Carlos Augusto" },
                    { 3, "88846663098", new DateTime(2022, 9, 13, 13, 42, 25, 0, DateTimeKind.Unspecified), new DateTime(2002, 9, 12, 12, 20, 1, 0, DateTimeKind.Unspecified), "Gabriel Carvalho" },
                    { 4, "45061531035", new DateTime(2023, 1, 8, 10, 12, 58, 0, DateTimeKind.Unspecified), new DateTime(1973, 4, 4, 22, 49, 14, 0, DateTimeKind.Unspecified), "Abel Ferreira" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteModel");
        }
    }
}
