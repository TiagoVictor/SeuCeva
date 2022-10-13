using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.TipoPlanoDto;

namespace SeuCevApi.Service
{
    public class TipoPlanoService : ITipoPlanoService
    {
        private readonly ITipoPlanoRepository _repository;

        public TipoPlanoService(ITipoPlanoRepository repository)
        {
            _repository = repository;
        }

        public async Task Delete(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _repository.Delete(model);
        }

        public async Task Edit(PlanTypeUpdateDto dto, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _repository.Edit(ConvertToModelUpdate(dto, model));
        }

        public IEnumerable<TipoPlano> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoPlano GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task Save(PlanTypeCreationDto dto)
        {
            await _repository.Save(ConvertToModelSave(dto));
        }

        private TipoPlano ConvertToModelSave(PlanTypeCreationDto dto)
        {
            return new TipoPlano
            {
                Descricao = dto.Descricao
            };
        }

        private TipoPlano ConvertToModelUpdate(PlanTypeUpdateDto dto, TipoPlano model)
        {
            model.Descricao = dto.Descricao;
            model.Ativo = dto.Ativo;
            return model;
        }
    }
}
