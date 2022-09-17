using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IClienteService
    {
        public Task Save(Cliente cliente);
        public Task Delete(Cliente cliente);
        public Task Edit(Cliente cliente);
        public IQueryable<Cliente> GetAll();
        public Cliente GetById(int id);
    }
}
