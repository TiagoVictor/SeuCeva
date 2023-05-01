using Microsoft.EntityFrameworkCore;
using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ClienteRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task DeleteAsync(Cliente cliente)
        {
            _applicationDbContext.Clientes.Remove(cliente);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Cliente cliente)
        {
            _applicationDbContext.Clientes.Update(cliente);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _applicationDbContext.Clientes
                .Where(x => x.Ativo)
                .Include(x => x.Documentos)
                .Include(x => x.Enderecos);
        }

        public Cliente GetById(int id)
        {
            return _applicationDbContext.Clientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public Task<bool> HasCreated(Cliente cliente)
        {
            return _applicationDbContext.Clientes
                .Where(x => x.Email == cliente.Email && x.PassWord == cliente.PassWord).AnyAsync();
        }

        public async Task SaveAsync(Cliente cliente)
        {
            await _applicationDbContext.Clientes.AddAsync(cliente);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
