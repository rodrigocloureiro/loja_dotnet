using at_test.Data.Models;
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
        }
    }
}
