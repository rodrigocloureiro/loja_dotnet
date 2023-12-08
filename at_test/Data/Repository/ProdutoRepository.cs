using at_test.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace at_test.Data.Repository
{
    public class ProdutoRepository : IRepositoryProduto
    {
        private EsportivaContext _context;
        private IWebHostEnvironment _env;

        public ProdutoRepository(EsportivaContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }

        public void Add(ProdutoModel novoProduto)
        {
            novoProduto.DataRegistro = DateTime.Now;

            if (novoProduto.Upload is not null)
            {
                novoProduto.NomeImagem = novoProduto.Upload.FileName;

                string arquivoImagem = Path.Combine(_env.ContentRootPath, "wwwroot/images/produtos", novoProduto.Upload.FileName);

                using (FileStream fs = new FileStream(arquivoImagem, FileMode.Create))
                {
                    novoProduto.Upload.CopyTo(fs);
                }
            }
            else
            {
                novoProduto.NomeImagem = "imagem_naocadastrada.png";
            }

            _context.Produtos.Add(novoProduto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            ProdutoModel produtoDeletado = GetById(id);

            _context.Produtos.Remove(produtoDeletado);
            _context.SaveChanges();
        }

        public List<ProdutoModel> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public ProdutoModel GetById(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public void Update(int id, ProdutoModel produtoEditado)
        {
            ProdutoModel produtoAntigo = _context.Produtos
                .AsNoTracking()
                .FirstOrDefault(p => p.Id == id);

            if (produtoEditado.Upload is null)
            {
                produtoEditado.NomeImagem = produtoAntigo.NomeImagem;
            }
            else
            {
                produtoEditado.NomeImagem = produtoEditado.Upload.FileName;

                string arquivoImagem = Path.Combine(_env.ContentRootPath, "wwwroot/images/produtos", produtoEditado.Upload.FileName);

                using (FileStream fs = new FileStream(arquivoImagem, FileMode.Create))
                {
                    produtoEditado.Upload.CopyTo(fs);
                }
            }

            produtoEditado.DataRegistro = produtoAntigo.DataRegistro;

            _context.Produtos.Update(produtoEditado);
            _context.SaveChanges();
        }
    }
}
