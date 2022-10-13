using SeuCevApi.Model;
using static SeuCevApi.Dto.ClienteDto;

namespace SeuCevApi.Service.Interface
{
    public interface IClienteService
    {
        public Task Save(ClientCreationDto dto);
        public Task Delete(int id);
        public Task Edit(ClientUpdateDto dto, int id);
        public IEnumerable<Cliente> GetAll();
        public Cliente GetById(int id);
    }
}
