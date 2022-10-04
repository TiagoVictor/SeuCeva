using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
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

        public async Task Delete(OfertaDto dto)
        {
            await _ofertaRepository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(OfertaDto dto)
        {
            await _ofertaRepository.Edit(ConvertToModel(dto));
        }

        public IQueryable<Oferta> GetAll()
        {
            return _ofertaRepository.GetAll();
        }

        public Oferta GetById(int id)
        {
            return _ofertaRepository.GetById(id);
        }

        public async Task Save(OfertaDto dto)
        {
            await _ofertaRepository.Save(ConvertToModel(dto));
        }

        private Oferta ConvertToModel(OfertaDto dto)
        {
            return new Oferta
            {
                Id = dto.Id,
                Titulo = dto.Titulo,
                Descricao = dto.Descricao,
                Quantidade = dto.Quantidade,
                Alcance = dto.Alcance
            };
        }
    }
}
