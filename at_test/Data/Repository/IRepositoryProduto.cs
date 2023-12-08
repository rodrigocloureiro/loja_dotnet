using at_test.Data.Models;

namespace at_test.Data.Repository
{
    public interface IRepositoryProduto
    {
        public List<ProdutoModel> GetAll();
        public ProdutoModel GetById(int id);
        public void Add(ProdutoModel produto);
        public void Update(int id, ProdutoModel produto);
        public void Delete(int id);
    }
}
