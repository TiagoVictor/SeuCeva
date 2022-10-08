using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class DocumentoService : IDocumentoService
    {
        private readonly IDocumentoRepository _documentoRepository;

        public DocumentoService(IDocumentoRepository documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }

        public async Task Delete(DocumentoDto dto)
        {
            await _documentoRepository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(DocumentoDto dto)
        {
            await _documentoRepository.Edit(ConvertToModel(dto));
        }

        public IQueryable<Documento> GetAll()
        {
            return _documentoRepository.GetAll();
        }

        public Documento GetById(int id)
        {
            return _documentoRepository.GetById(id);
        }

        public async Task Save(DocumentoDto dto)
        {
            await _documentoRepository.Save(ConvertToModel(dto));
        }

        public Documento ConvertToModel(DocumentoDto dto)
        {
            return new Documento
            {
                Id = dto.Id,
                Tipo = dto.Tipo,
                Numero = dto.Numero,
                Ativo = dto.Ativo
            };
        }
    }
}
