using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Cliente
{
    public class DetalhesClienteModel : PageModel
    {
        private IRepositoryCliente _repo;
        public ClienteModel Cliente { get; set; }

        public DetalhesClienteModel(IRepositoryCliente repo)
        {
            _repo = repo;
        }

        public void OnGet(int id)
        {
            Cliente = _repo.GetById(id);
        }
    }
}
