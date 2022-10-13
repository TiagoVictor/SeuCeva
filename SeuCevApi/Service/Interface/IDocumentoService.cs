using SeuCevApi.Model;
using static SeuCevApi.Dto.DocumentoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IDocumentoService
    {
        public Task Save(DocumentCreationDto dto);
        public Task Delete(DocumentCreationDto dto);
        public Task Edit(DocumentCreationDto dto);
        public IEnumerable<Documento> GetAll();
        public Documento GetById(int id);
    }
}
