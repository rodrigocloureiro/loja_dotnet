using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Produto
{
    public class DeletarProdutoModel : PageModel
    {
        private IRepositoryProduto _repo;
        public ProdutoModel Produto { get; set; }

        public DeletarProdutoModel(IRepositoryProduto repo)
        {
            _repo = repo;
        }

        public void OnGet(int id)
        {
            Produto = _repo.GetById(id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repo.Delete(id);

            return RedirectToPage("ExibirProdutos");
        }
    }
}
