using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
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

        public async Task Delete(DocumentCreationDto dto)
        {
            await _documentoRepository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(DocumentCreationDto dto)
        {
            await _documentoRepository.Edit(ConvertToModel(dto));
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
            await _documentoRepository.Save(ConvertToModel(dto));
        }

        public Documento ConvertToModel(DocumentCreationDto dto)
        {
            return new Documento
            {
                Tipo = dto.Tipo,
                Numero = dto.Numero,
            };
        }
    }
}
