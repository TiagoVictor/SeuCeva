using SeuCevApi.Dto;
using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoClienteService
    {
        public Task Save(TipoClienteDto tipoCliente);
        public Task Delete(TipoClienteDto tipoCliente);
        public Task Edit(TipoClienteDto tipoCliente);
        public IQueryable<TipoCliente> GetAll();
        public TipoCliente GetById(int id);
    }
}
