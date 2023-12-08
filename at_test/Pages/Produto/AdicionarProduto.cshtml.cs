using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Produto
{
    public class AdicionarProdutoModel : PageModel
    {
        private IRepositoryProduto _repo;
        [BindProperty]
        public ProdutoModel NovoProduto { get; set; }

        public AdicionarProdutoModel(IRepositoryProduto repo)
        {
            _repo = repo;
        }

        public void OnGet(int id)
        {
            NovoProduto = _repo.GetById(id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repo.Add(NovoProduto);

            return RedirectToPage("ExibirProdutos");
        }
    }
}
