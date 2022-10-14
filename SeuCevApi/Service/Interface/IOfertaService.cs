using SeuCevApi.Model;
using static SeuCevApi.Dto.OfertaDto;

namespace SeuCevApi.Service.Interface
{
    public interface IOfertaService
    {
        public Task SaveAsync(OfferCreationDto dto);
        public Task DeleteAsync(int id);
        public Task EditAsync(OfferUpdateDto dto, int id);
        public IEnumerable<Oferta> GetAll();
        public Oferta GetById(int id);
    }
}
