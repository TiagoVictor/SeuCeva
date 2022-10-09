using SeuCevApi.Dto;
using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IOfertaService
    {
        public Task Save(OfertaDto dto);
        public Task Delete(OfertaDto dto);
        public Task Edit(OfertaDto dto);
        public IEnumerable<Oferta> GetAll();
        public Oferta GetById(int id);
    }
}
