using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class TipoClienteRepository : ITipoClienteRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TipoClienteRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Delete(TipoCliente tipoCliente)
        {
            _applicationDbContext.TiposClientes.Remove(tipoCliente);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task Edit(TipoCliente tipoCliente)
        {
            _applicationDbContext.TiposClientes.Update(tipoCliente);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IQueryable<TipoCliente> GetAll()
        {
            return _applicationDbContext.TiposClientes.Where(x => x.Ativo);
        }

        public TipoCliente GetById(int id)
        {
            return _applicationDbContext.TiposClientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task Save(TipoCliente tipoCliente)
        {
            await _applicationDbContext.TiposClientes.AddAsync(tipoCliente);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
