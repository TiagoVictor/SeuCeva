using SeuCevApi.Model;
using static SeuCevApi.Dto.OfertaDto;

namespace SeuCevApi.Service.Interface
{
    public interface IOfertaService
    {
        public Task Save(OfferCreationDto dto);
        public Task Delete(int id);
        public Task Edit(OfferUpdateDto dto, int id);
        public IEnumerable<Oferta> GetAll();
        public Oferta GetById(int id);
    }
}
