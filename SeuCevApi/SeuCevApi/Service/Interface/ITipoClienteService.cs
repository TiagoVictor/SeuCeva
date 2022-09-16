using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoClienteService
    {
        public Task Save(TipoCliente tipoCliente);
        public Task Delete(TipoCliente tipoCliente);
        public Task Edit(TipoCliente tipoCliente);
        public IQueryable<TipoCliente> GetAll();
        public TipoCliente GetById(int id);
    }
}
