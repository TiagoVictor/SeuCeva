using SeuCevApi.Dto;
using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoPlanoService
    {
        public Task Save(TipoPlanoDto dto);
        public Task Delete(TipoPlanoDto dto);
        public Task Edit(TipoPlanoDto dto);
        public IEnumerable<TipoPlano> GetAll();
        public TipoPlano GetById(int id);
    }
}
