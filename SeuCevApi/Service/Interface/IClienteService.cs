using SeuCevApi.Model;
using static SeuCevApi.Dto.ClienteDto;

namespace SeuCevApi.Service.Interface
{
    public interface IClienteService
    {
        public Task SaveAsync(ClientCreationDto dto);
        public Task DeleteAsync(int id);
        public Task EditAsync(ClientUpdateDto dto, int id);
        public IEnumerable<Cliente> GetAll();
        public Cliente GetById(int id);
    }
}
