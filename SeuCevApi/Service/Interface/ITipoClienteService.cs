using SeuCevApi.Model;
using static SeuCevApi.Dto.TipoClienteDto;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoClienteService
    {
        public Task Save(ClientTypeCreationDto tipoCliente);
        public Task Delete(int id);
        public Task Edit(ClientTypeUpdate tipoCliente, int id);
        public IEnumerable<TipoCliente> GetAll();
        public TipoCliente GetById(int id);
    }
}
