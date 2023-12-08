using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Cliente
{
    public class ExibirClientesModel : PageModel
    {
        private IRepositoryCliente _repo;
        public List<ClienteModel> Clientes { get; set; }

        public ExibirClientesModel(IRepositoryCliente repo)
        {
            _repo = repo;
        }

        public void OnGet(int id)
        {
            Clientes = _repo.GetAll();
        }
    }
}
