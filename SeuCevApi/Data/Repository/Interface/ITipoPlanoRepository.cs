using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface ITipoPlanoRepository
    {
        public Task Save(TipoPlano tipoPlano);
        public Task Delete(TipoPlano tipoPlano);
        public Task Edit(TipoPlano tipoPlano);
        public IEnumerable<TipoPlano> GetAll();
        public TipoPlano GetById(int id);
    }
}
