using SeuCevApi.Data.Repository.Interface;
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

        public async Task Delete(Documento documento)
        {
            await _documentoRepository.Delete(documento);
        }

        public async Task Edit(Documento documento)
        {
            await _documentoRepository.Edit(documento);
        }

        public IQueryable<Documento> GetAll()
        {
            return _documentoRepository.GetAll();
        }

        public Documento GetById(int id)
        {
            return _documentoRepository.GetById(id);
        }

        public async Task Save(Documento documento)
        {
            await _documentoRepository.Save(documento);
        }
    }
}
