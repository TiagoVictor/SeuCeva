using SeuCevApi.Model;
using static SeuCevApi.Dto.ClienteDto;

namespace SeuCevApi.Service.Interface
{
    public interface IClienteService
    {
        public Task Save(ClientCreationDto dto);
        public Task Delete(ClientCreationDto dto);
        public Task Edit(ClientCreationDto dto);
        public IEnumerable<Cliente> GetAll();
        public Cliente GetById(int id);
    }
}
