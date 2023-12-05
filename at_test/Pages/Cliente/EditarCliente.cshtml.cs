using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Cliente
{
    public class EditarClienteModel : PageModel
    {
        private EsportivaContext _context;
        [BindProperty]
        public ClienteModel ClienteEditado { get; set; }

        public EditarClienteModel(EsportivaContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            ClienteEditado = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ClienteEditado.DataCadastro = _context.Clientes
                .AsNoTracking()
                .FirstOrDefault(cliente => cliente.Id == id)
                .DataCadastro;

            _context.Clientes.Update(ClienteEditado);
            _context.SaveChanges();

            return RedirectToPage("ExibirClientes");
        }
    }
}
