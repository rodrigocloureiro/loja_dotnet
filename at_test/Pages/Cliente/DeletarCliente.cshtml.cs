using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Cliente
{
    public class DeletarClienteModel : PageModel
    {
        private EsportivaContext _context;
        public ClienteModel Cliente { get; set; }

        public DeletarClienteModel(EsportivaContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clientes.Remove(_context.Clientes.Find(id));
            _context.SaveChanges();

            return RedirectToPage("ExibirClientes");
        }
    }
}
