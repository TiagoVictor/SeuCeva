using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class OfertaService : IOfertaService
    {
        private readonly IOfertaRepository _ofertaRepository;

        public OfertaService(IOfertaRepository ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;
        }

        public async Task Delete(Oferta oferta)
        {
            await _ofertaRepository.Delete(oferta);
        }

        public async Task Edit(Oferta oferta)
        {
            await _ofertaRepository.Edit(oferta);
        }

        public IQueryable<Oferta> GetAll()
        {
            return _ofertaRepository.GetAll();
        }

        public Oferta GetById(int id)
        {
            return _ofertaRepository.GetById(id);
        }

        public async Task Save(Oferta oferta)
        {
            await _ofertaRepository.Save(oferta);
        }
    }
}
