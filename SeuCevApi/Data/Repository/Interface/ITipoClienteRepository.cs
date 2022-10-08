using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface ITipoClienteRepository
    {
        public Task Save(TipoCliente tipoCliente);
        public Task Delete(TipoCliente tipoCliente);
        public Task Edit(TipoCliente tipoCliente);
        public IQueryable<TipoCliente> GetAll();
        public TipoCliente GetById(int id);
    }
}
