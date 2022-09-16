using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoPlanoService
    {
        public Task Save(TipoPlano tipoPlano);
        public Task Delete(TipoPlano tipoPlano);
        public Task Edit(TipoPlano tipoPlano);
        public IQueryable<TipoPlano> GetAll();
        public TipoPlano GetById(int id);
    }
}
