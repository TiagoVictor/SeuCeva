using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
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

        public async Task Delete(TipoClienteDto tipoCliente)
        {
            var model = new TipoCliente();
            await _repository.Delete(model);
        }

        public async Task Edit(TipoClienteDto tipoCliente)
        {
            var model = new TipoCliente();
            await _repository.Edit(model);
        }

        public IQueryable<TipoCliente> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoCliente GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task Save(TipoClienteDto tipoCliente)
        {
            var model = new TipoCliente();
            await _repository.Save(model);
        }
    }
}
