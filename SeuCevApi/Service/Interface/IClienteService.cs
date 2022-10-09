using SeuCevApi.Dto;
using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IClienteService
    {
        public Task Save(ClienteDto dto);
        public Task Delete(ClienteDto dto);
        public Task Edit(ClienteDto dto);
        public IEnumerable<Cliente> GetAll();
        public Cliente GetById(int id);
    }
}
