using at_test.Data.Models;
using at_test.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Produto
{
    public class EditarProdutoModel : PageModel
    {
        private EsportivaContext _context;
        [BindProperty]
        public ProdutoModel ProdutoEditado { get; set; }

        public EditarProdutoModel(EsportivaContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            ProdutoEditado = _context.Produtos.FirstOrDefault(prod => prod.Id == id);
        }

        public IActionResult OnPost(int id)
        {
            ProdutoModel produtoAntigo = _context.Produtos.AsNoTracking().FirstOrDefault(prod => prod.Id == id);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (ProdutoEditado.Upload is null)
            {
                ProdutoEditado.NomeImagem = produtoAntigo.NomeImagem;
            }
            else
            {
                ProdutoEditado.NomeImagem = ProdutoEditado.Upload.FileName;
            }

            ProdutoEditado.DataRegistro = _context.Produtos
                .AsNoTracking()
                .FirstOrDefault(produto => produto.Id == id)
                .DataRegistro;

            _context.Produtos.Update(ProdutoEditado);
            _context.SaveChanges();

            return RedirectToPage("ExibirProdutos");
        }
    }
}
