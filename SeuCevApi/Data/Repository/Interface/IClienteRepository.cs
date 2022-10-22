using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IClienteRepository
    {
        public Task SaveAsync(Cliente cliente);
        public Task DeleteAsync(Cliente cliente);
        public Task EditAsync(Cliente cliente);
        public IEnumerable<Cliente> GetAll();
        public Cliente GetById(int id);
        public Task<bool> HasCreated(Cliente cliente);
    }
}
