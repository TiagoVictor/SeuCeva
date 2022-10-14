using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface ITipoClienteRepository
    {
        public Task SaveAsync(TipoCliente tipoCliente);
        public Task DeleteAsync(TipoCliente tipoCliente);
        public Task EditAsync(TipoCliente tipoCliente);
        public IEnumerable<TipoCliente> GetAll();
        public TipoCliente GetById(int id);
    }
}
