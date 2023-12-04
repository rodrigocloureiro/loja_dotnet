using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace at_test.Data
{
    public class EsportivaContext : DbContext
    {
        public EsportivaContext(DbContextOptions<EsportivaContext> options) : base(options) { }

        public DbSet<ProdutoModel> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoModel>().HasData(
                new ProdutoModel()
                {
                    Id = 1,
                    Nome = "Areia Lavada Saco 1KG",
                    Descricao = "Areia lavada Saco 1KG",
                    Preco = 2.90m,
                    Quantidade = 500,
                    NomeImagem = "areia.png"
                },
                new ProdutoModel()
                {
                    Id = 2,
                    Nome = "Cimento Votoram 25KG",
                    Descricao = "Saco cimento votoram 25KG",
                    Preco = 27.90m,
                    Quantidade = 300,
                    NomeImagem = "cimento_votoram.png"
                },
                new ProdutoModel()
                {
                    Id = 3,
                    Nome = "Tijolo Tradicional",
                    Descricao = "Tijolo Tradicional",
                    Preco = 4.90m,
                    Quantidade = 400,
                    NomeImagem = "tijolo.png"
                },
                new ProdutoModel()
                {
                    Id = 4,
                    Nome = "Tubo Esgoto PVC Série Normal 6M",
                    Descricao = "Tubo Esgoto PVC Série Normal 6M",
                    Preco = 5.90m,
                    Quantidade = 100,
                    NomeImagem = "tubo_esgoto_pvc_6m.png"
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
