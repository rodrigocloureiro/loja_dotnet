using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Cliente
{
    public class ExibirClientesModel : PageModel
    {
        private EsportivaContext _context;
        public List<ClienteModel> Clientes { get; set; }

        public ExibirClientesModel(EsportivaContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Clientes = _context.Clientes.ToList();
        }
    }
}
