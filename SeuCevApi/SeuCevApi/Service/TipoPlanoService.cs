using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class TipoPlanoService : ITipoPlanoService
    {
        private readonly ITipoPlanoRepository _repository;

        public TipoPlanoService(ITipoPlanoRepository repository)
        {
            _repository = repository;
        }

        public async Task Delete(TipoPlanoDto dto)
        {
            await _repository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(TipoPlanoDto dto)
        {
            await _repository.Edit(ConvertToModel(dto));
        }

        public IQueryable<TipoPlano> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoPlano GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task Save(TipoPlanoDto dto)
        {
            await _repository.Save(ConvertToModel(dto));
        }

        private TipoPlano ConvertToModel(TipoPlanoDto dto)
        {
            return new TipoPlano
            {
                Id = dto.Id,
                Descricao = dto.Descricao
            };
        }
    }
}
