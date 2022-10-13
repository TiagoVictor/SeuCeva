using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.TipoClienteDto;

namespace SeuCevApi.Service
{
    public class TipoClienteService : ITipoClienteService
    {
        private readonly ITipoClienteRepository _repository;

        public TipoClienteService(ITipoClienteRepository tipoClienteRepository)
        {
            _repository = tipoClienteRepository;
        }

        public async Task DeleteAsync(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _repository.DeleteAsync(model);
        }

        public async Task EditAsync(ClientTypeUpdate tipoCliente, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _repository.EditAsync(ConvertToModelUpdate(tipoCliente, model));
        }

        public IEnumerable<TipoCliente> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoCliente GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task SaveAsync(ClientTypeCreationDto tipoCliente)
        {
            await _repository.SaveAsync(ConvertToModel(tipoCliente));
        }

        private TipoCliente ConvertToModel(ClientTypeCreationDto dto)
        {
            return new TipoCliente
            {
                Descricao = dto.Descricao,
            };
        }

        private TipoCliente ConvertToModelUpdate(ClientTypeUpdate dto, TipoCliente model)
        {
            model.Ativo = dto.Ativo;
            model.Descricao = dto.Descricao;

            return model;
        }
    }
}
