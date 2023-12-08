using at_test.Data.Models;
using at_test.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using at_test.Data.Repository;

namespace at_test.Pages.Produto
{
    public class EditarProdutoModel : PageModel
    {
        private IRepositoryProduto _repo;
        [BindProperty]
        public ProdutoModel ProdutoEditado { get; set; }

        public EditarProdutoModel(IRepositoryProduto repo)
        {
            _repo = repo;
        }
        public void OnGet(int id)
        {
            ProdutoEditado = _repo.GetById(id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repo.Update(id, ProdutoEditado);

            return RedirectToPage("ExibirProdutos");
        }
    }
}
