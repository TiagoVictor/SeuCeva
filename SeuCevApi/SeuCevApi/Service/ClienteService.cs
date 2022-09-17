using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Delete(Cliente cliente)
        {
            await _clienteRepository.Delete(cliente);
        }

        public async Task Edit(Cliente cliente)
        {
            await _clienteRepository.Edit(cliente);
        }

        public IQueryable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public async Task Save(Cliente cliente)
        {
            await _clienteRepository.Save(cliente);
        }
    }
}
