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

        public async Task Delete(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _repository.Delete(model);
        }

        public async Task Edit(ClientTypeUpdate tipoCliente, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _repository.Edit(ConvertToModelUpdate(tipoCliente, model));
        }

        public IEnumerable<TipoCliente> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoCliente GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task Save(ClientTypeCreationDto tipoCliente)
        {
            await _repository.Save(ConvertToModel(tipoCliente));
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
