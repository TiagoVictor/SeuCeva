using SeuCevApi.Data.Repository.Interface;
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

        public async Task Delete(TipoPlano tipoPlano)
        {
            await _repository.Delete(tipoPlano);
        }

        public async Task Edit(TipoPlano tipoPlano)
        {
            await _repository.Edit(tipoPlano);
        }

        public IQueryable<TipoPlano> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoPlano GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task Save(TipoPlano tipoPlano)
        {
            await _repository.Save(tipoPlano);
        }
    }
}
