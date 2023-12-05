using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Cliente
{
    public class DetalhesClienteModel : PageModel
    {
        private EsportivaContext _context;
        public ClienteModel Cliente { get; set; }

        public DetalhesClienteModel(EsportivaContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
        }
    }
}
