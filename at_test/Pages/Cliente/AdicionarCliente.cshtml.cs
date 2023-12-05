using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Cliente
{
    public class AdicionarClienteModel : PageModel
    {
        private EsportivaContext _context;
        [BindProperty]
        public ClienteModel NovoCliente { get; set; }

        public AdicionarClienteModel(EsportivaContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NovoCliente.DataCadastro = DateTime.Now;

            _context.Clientes.Add(NovoCliente);
            _context.SaveChanges();

            return RedirectToPage("ExibirClientes");
        }
    }
}
