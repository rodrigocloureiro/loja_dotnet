using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Produto
{
    public class DetalhesProdutoModel : PageModel
    {
        private EsportivaContext _context;
        public ProdutoModel Produto { get; set; }

        public DetalhesProdutoModel(EsportivaContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        }
    }
}
