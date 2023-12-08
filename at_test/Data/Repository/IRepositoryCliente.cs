using at_test.Data.Models;

namespace at_test.Data.Repository
{
    public interface IRepositoryCliente
    {
        public List<ClienteModel> GetAll();
        public ClienteModel GetById(int id);
        public void Add(ClienteModel cliente);
        public void Update(int id, ClienteModel cliente);
        public void Delete(int id);
    }
}
