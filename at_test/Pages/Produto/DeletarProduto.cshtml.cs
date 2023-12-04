using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Produto
{
    public class DeletarProdutoModel : PageModel
    {
        private EsportivaContext _context;
        public ProdutoModel Produto { get; set; }

        public DeletarProdutoModel(EsportivaContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Produto = _context.Produtos.FirstOrDefault(prod => prod.Id == id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produtos.Remove(_context.Produtos.Find(id));
            _context.SaveChanges();

            return RedirectToPage("ExibirProdutos");
        }
    }
}
