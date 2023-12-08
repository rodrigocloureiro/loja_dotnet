using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Cliente
{
    public class AdicionarClienteModel : PageModel
    {
        private IRepositoryCliente _repo;
        [BindProperty]
        public ClienteModel NovoCliente { get; set; }

        public AdicionarClienteModel(IRepositoryCliente repo)
        {
            _repo = repo;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repo.Add(NovoCliente);

            return RedirectToPage("ExibirClientes");
        }
    }
}
