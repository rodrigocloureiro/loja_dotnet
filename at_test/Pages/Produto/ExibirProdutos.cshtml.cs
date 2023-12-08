using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Produto
{
    public class ExibirProdutosModel : PageModel
    {
        private IRepositoryProduto _repo;
        public List<ProdutoModel> Produtos { get; set; }

        public ExibirProdutosModel(IRepositoryProduto repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
            Produtos = _repo.GetAll();
        }
    }
}
