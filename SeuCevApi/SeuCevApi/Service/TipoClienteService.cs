using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class TipoClienteService : ITipoClienteService
    {
        private readonly ITipoClienteRepository _repository;

        public TipoClienteService(ITipoClienteRepository tipoClienteRepository)
        {
            _repository = tipoClienteRepository;
        }

        public async Task Delete(TipoCliente tipoCliente)
        {
            await _repository.Delete(tipoCliente);
        }

        public async Task Edit(TipoCliente tipoCliente)
        {
            await _repository.Edit(tipoCliente);
        }

        public IQueryable<TipoCliente> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoCliente GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task Save(TipoCliente tipoCliente)
        {
            await _repository.Save(tipoCliente);
        }
    }
}
