using at_test.Data;
using at_test.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages.Produto
{
    public class AdicionarProdutoModel : PageModel
    {
        private EsportivaContext _context;
        private IWebHostEnvironment _environment;
        [BindProperty]
        public ProdutoModel NovoProduto { get; set; }

        public AdicionarProdutoModel(EsportivaContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public void OnGet(int id)
        {
            NovoProduto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (NovoProduto.Upload is not null)
            {
                NovoProduto.NomeImagem = NovoProduto.Upload.FileName;

                string arquivoImagem = Path.Combine(_environment.ContentRootPath, "wwwroot/images/produtos", NovoProduto.Upload.FileName);

                using (FileStream fs = new FileStream(arquivoImagem, FileMode.Create))
                {
                    NovoProduto.Upload.CopyTo(fs);
                }
            }
            else
            {
                NovoProduto.NomeImagem = "imagem_naocadastrada.png";
            }

            NovoProduto.DataRegistro = DateTime.Now;

            _context.Produtos.Add(NovoProduto);
            _context.SaveChanges();

            return RedirectToPage("ExibirProdutos");
        }
    }
}
