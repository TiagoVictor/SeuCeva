using SeuCevApi.Model;
using static SeuCevApi.Dto.TipoPlanoDto;

namespace SeuCevApi.Service.Interface
{
    public interface ITipoPlanoService
    {
        public Task SaveAsync(PlanTypeCreationDto dto);
        public Task DeleteAsync(int id);
        public Task EditAsync(PlanTypeUpdateDto dto, int id);
        public IEnumerable<TipoPlano> GetAll();
        public TipoPlano GetById(int id);
    }
}
