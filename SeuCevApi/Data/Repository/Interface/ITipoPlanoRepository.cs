using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface ITipoPlanoRepository
    {
        public Task SaveAsync(TipoPlano tipoPlano);
        public Task DeleteAsync(TipoPlano tipoPlano);
        public Task EditAsync(TipoPlano tipoPlano);
        public IEnumerable<TipoPlano> GetAll();
        public TipoPlano GetById(int id);
    }
}
