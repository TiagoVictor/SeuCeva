using SeuCevApi.Model;
using static SeuCevApi.Dto.TipoPlanoDto;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoPlanoService
    {
        public Task Save(PlanTypeCreationDto dto);
        public Task Delete(int id);
        public Task Edit(PlanTypeUpdateDto dto, int id);
        public IEnumerable<TipoPlano> GetAll();
        public TipoPlano GetById(int id);
    }
}
