using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Produto
{
    public class DetalhesProdutoModel : PageModel
    {
        private IRepositoryProduto _repo;
        public ProdutoModel Produto { get; set; }

        public DetalhesProdutoModel(IRepositoryProduto repo)
        {
            _repo = repo;
        }

        public void OnGet(int id)
        {
            Produto = _repo.GetById(id);
        }
    }
}
