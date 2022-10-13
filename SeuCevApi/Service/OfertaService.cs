using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.OfertaDto;

namespace SeuCevApi.Service
{
    public class OfertaService : IOfertaService
    {
        private readonly IOfertaRepository _ofertaRepository;

        public OfertaService(IOfertaRepository ofertaRepository, IEmailService emailService)
        {
            _ofertaRepository = ofertaRepository;
        }

        public async Task Delete(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _ofertaRepository.Delete(model);
        }

        public async Task Edit(OfferUpdateDto dto, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _ofertaRepository.Edit(ConvertToModelUpdate(dto, model));
        }

        public IEnumerable<Oferta> GetAll()
        {
            return _ofertaRepository.GetAll();
        }

        public Oferta GetById(int id)
        {
            return _ofertaRepository.GetById(id);
        }

        public async Task Save(OfferCreationDto dto)
        {
            await _ofertaRepository.Save(ConvertToModelCreate(dto));
        }

        private Oferta ConvertToModelCreate(OfferCreationDto dto)
        {
            return new Oferta
            {
                Titulo = dto.Titulo,
                Descricao = dto.Descricao,
                Quantidade = dto.Quantidade,
                Alcance = dto.Alcance,
            };
        }

        private Oferta ConvertToModelUpdate(OfferUpdateDto dto, Oferta model)
        {
            model.Ativo = dto.Ativo;
            model.Descricao = dto.Descricao;
            model.Titulo = dto.Titulo;
            model.Alcance = dto.Alcance;

            return model;
        }
    }
}
