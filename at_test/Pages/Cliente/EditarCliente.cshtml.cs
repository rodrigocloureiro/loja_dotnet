using at_test.Data;
using at_test.Data.Models;
using at_test.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Cliente
{
    public class EditarClienteModel : PageModel
    {
        private IRepositoryCliente _repo;
        [BindProperty]
        public ClienteModel ClienteEditado { get; set; }

        public EditarClienteModel(IRepositoryCliente repo)
        {
            _repo = repo;
        }

        public void OnGet(int id)
        {
            ClienteEditado = _repo.GetById(id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repo.Update(id, ClienteEditado);

            return RedirectToPage("ExibirClientes");
        }
    }
}
