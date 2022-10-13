using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.DocumentoDto;

namespace SeuCevApi.Service
{
    public class DocumentoService : IDocumentoService
    {
        private readonly IDocumentoRepository _documentoRepository;

        public DocumentoService(IDocumentoRepository documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }

        public async Task Delete(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _documentoRepository.Delete(model);
        }

        public async Task Edit(DocumentUpdateDto dto, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado");

            await _documentoRepository.Edit(ConvertToModelUpdate(dto, model));
        }

        public IEnumerable<Documento> GetAll()
        {
            return _documentoRepository.GetAll();
        }

        public Documento GetById(int id)
        {
            return _documentoRepository.GetById(id);
        }

        public async Task Save(DocumentCreationDto dto)
        {
            await _documentoRepository.Save(ConvertToModelCreation(dto));
        }

        private Documento ConvertToModelCreation(DocumentCreationDto dto)
        {
            return new Documento
            {
                Tipo = dto.Tipo,
                Numero = dto.Numero,
            };
        }

        private Documento ConvertToModelUpdate(DocumentUpdateDto dto, Documento model)
        {
            model.Tipo = dto.Tipo;
            model.Numero = dto.Numero;
            model.Ativo = dto.Ativo;

            return model;
        }
    }
}
