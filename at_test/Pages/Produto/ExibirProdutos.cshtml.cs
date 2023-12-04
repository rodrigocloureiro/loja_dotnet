using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Produto
{
    public class ExibirProdutosModel : PageModel
    {
        private EsportivaContext _context;
        public List<ProdutoModel> Produtos { get; set; }

        public ExibirProdutosModel(EsportivaContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos.ToListAsync();
        }
    }
}
