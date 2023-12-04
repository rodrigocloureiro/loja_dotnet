using at_test.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace at_test.Data
{
    public class EsportivaContext : DbContext
    {
        public EsportivaContext(DbContextOptions<EsportivaContext> options) : base(options) { }

        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}
