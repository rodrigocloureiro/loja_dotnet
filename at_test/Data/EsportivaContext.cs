using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace at_test.Data
{
    public class EsportivaContext : DbContext
    {
        public EsportivaContext(DbContextOptions<EsportivaContext> options) : base(options) { }

        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoModel>().HasData(
                new ProdutoModel()
                {
                    Id = 10,
                    Nome = "Camisa Vasco Branca III 2022/2023",
                    Descricao = "Camisa Vasco Branca III (Edição Especial) 2022/2023 – Versão Torcedor",
                    Preco = 359.90m,
                    Quantidade = 500,
                    NomeImagem = "camisa_vasco_III.png",
                    DataRegistro = new DateTime(2022, 7, 29, 15, 36, 12)
                },
                new ProdutoModel()
                {
                    Id = 11,
                    Nome = "Camisa Vasco Preta III (Goleiro) 2022/2023",
                    Descricao = "Camisa Vasco Preta III (Goleiro - Edição Especial) 2022/2023 – Todos os Patrocinadores – Versão Torcedor",
                    Preco = 359.90m,
                    Quantidade = 450,
                    NomeImagem = "camisa_vasco_III_goleiro.png",
                    DataRegistro = new DateTime(2022, 7, 29, 15, 36, 12)
                },
                new ProdutoModel()
                {
                    Id = 12,
                    Nome = "Camisa Vasco III Branco – (Goleiro) 2023/2024",
                    Descricao = "Camisa Vasco III Branco – (Goleiro) 2023/2024 – Versão Torcedor",
                    Preco = 329.90m,
                    Quantidade = 300,
                    NomeImagem = "camisa_vasco_branco_goleiro_2023_2024.png",
                    DataRegistro = new DateTime(2023, 9, 25, 11, 17, 25)
                },
                new ProdutoModel()
                {
                    Id = 13,
                    Nome = "Camisa Vasco Azul Claro – (Goleiro) 2023/2024",
                    Descricao = "Camisa Vasco Azul Claro – (Goleiro) 2023/2024 – Versão Torcedor",
                    Preco = 299.90m,
                    Quantidade = 390,
                    NomeImagem = "camisa_vasco_goleiro_azul_claro_2023_2024.png",
                    DataRegistro = new DateTime(2023, 7, 12, 13, 34, 46)
                },
                new ProdutoModel()
                {
                    Id = 14,
                    Nome = "Camisa Al Nassr Home 2023/2024",
                    Descricao = "Camisa Al Nassr Home 2023/2024 – Versão Torcedor",
                    Preco = 299.90m,
                    Quantidade = 100,
                    NomeImagem = "camisa_al_nassr_home_2023_2024.png",
                    DataRegistro = new DateTime(2023, 8, 15, 10, 00, 05)
                },
                new ProdutoModel()
                {
                    Id = 15,
                    Nome = "Camisa Al Nassr Away 2023/2024",
                    Descricao = "Camisa Al Nassr Away 2023/2024 – Versão Torcedor",
                    Preco = 299.90m,
                    Quantidade = 70,
                    NomeImagem = "camisa_al_nassr_away_2023_2024.png",
                    DataRegistro = new DateTime(2023, 8, 15, 10, 00, 05)
                },
                new ProdutoModel()
                {
                    Id = 16,
                    Nome = "Camisa Benfica Away 2023/2024",
                    Descricao = "Camisa Benfica Away 2023/2024 – Versão Torcedor",
                    Preco = 299.90m,
                    Quantidade = 90,
                    NomeImagem = "camisa_benfica_away_2023_2024.png",
                    DataRegistro = new DateTime(2023, 8, 15, 10, 30, 05)
                },
                new ProdutoModel()
                {
                    Id = 17,
                    Nome = "Camisa Manchester United Verde (Goleiro) 2023/2024",
                    Descricao = "Camisa Manchester United (Goleiro) 2023/2024 Verde – Versão Torcedor",
                    Preco = 299.90m,
                    Quantidade = 50,
                    NomeImagem = "camisa_manchester_united_goleiro_2023_2024_verde.png",
                    DataRegistro = new DateTime(2023, 9, 17, 17, 02, 25)
                }
            );

            modelBuilder.Entity<ClienteModel>().HasData(
                new ClienteModel()
                {
                    Id = 1,
                    Nome = "Marcos Ramos",
                    Cpf = "41741808065",
                    DataNascimento = new DateTime(1998, 12, 5, 05, 46, 32),
                    DataCadastro = new DateTime(2022, 7, 29, 15, 36, 12)
                },
                new ClienteModel()
                {
                    Id = 2,
                    Nome = "Carlos Augusto",
                    Cpf = "66639368080",
                    DataNascimento = new DateTime(1987, 10, 7, 09, 26, 36),
                    DataCadastro = new DateTime(2021, 3, 2, 21, 12, 19)
                },
                new ClienteModel()
                {
                    Id = 3,
                    Nome = "Gabriel Carvalho",
                    Cpf = "88846663098",
                    DataNascimento = new DateTime(2002, 9, 12, 12, 20, 01),
                    DataCadastro = new DateTime(2022, 9, 13, 13, 42, 25)
                },
                new ClienteModel()
                {
                    Id = 4,
                    Nome = "Abel Ferreira",
                    Cpf = "45061531035",
                    DataNascimento = new DateTime(1973, 4, 4, 22, 49, 14),
                    DataCadastro = new DateTime(2023, 1, 8, 10, 12, 58)
                }
            );
        }
    }
}
