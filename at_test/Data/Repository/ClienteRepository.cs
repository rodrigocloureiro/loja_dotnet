using at_test.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace at_test.Data.Repository
{
    public class ClienteRepository : IRepositoryCliente
    {
        private EsportivaContext _context;

        public ClienteRepository(EsportivaContext context)
        {
            _context = context;
        }

        public void Add(ClienteModel cliente)
        {
            cliente.DataCadastro = DateTime.Now;

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            ClienteModel produtoDeletado = GetById(id);

            _context.Clientes.Remove(produtoDeletado);
            _context.SaveChanges();
        }

        public List<ClienteModel> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public ClienteModel GetById(int id)
        {
            return _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
        }

        public void Update(int id, ClienteModel cliente)
        {
            cliente.DataCadastro = _context.Clientes
                .AsNoTracking()
                .FirstOrDefault(cliente => cliente.Id == id)
                .DataCadastro;

            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
    }
}
