using SeuCevApi.Model;
using static SeuCevApi.Dto.TipoClienteDto;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoClienteService
    {
        public Task SaveAsync(ClientTypeCreationDto tipoCliente);
        public Task DeleteAsync(int id);
        public Task EditAsync(ClientTypeUpdate tipoCliente, int id);
        public IEnumerable<TipoCliente> GetAll();
        public TipoCliente GetById(int id);
    }
}
