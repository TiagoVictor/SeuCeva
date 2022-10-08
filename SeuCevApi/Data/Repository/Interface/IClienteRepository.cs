using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IClienteRepository
    {
        public Task Save(Cliente cliente);
        public Task Delete(Cliente cliente);
        public Task Edit(Cliente cliente);
        public IQueryable<Cliente> GetAll();
        public Cliente GetById(int id);
    }
}
