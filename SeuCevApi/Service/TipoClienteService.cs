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
            await _repository.Delete(ConvertToModel(tipoCliente));
        }

        public async Task Edit(TipoClienteDto tipoCliente)
        {
            await _repository.Edit(ConvertToModel(tipoCliente));
        }

        public IEnumerable<TipoCliente> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoCliente GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task Save(TipoClienteDto tipoCliente)
        {
            await _repository.Save(ConvertToModel(tipoCliente));
        }

        private TipoCliente ConvertToModel(TipoClienteDto dto)
        {
            return new TipoCliente
            {
                Descricao = dto.Descricao,
                Ativo = dto.Ativo
            };
        }
    }
}
