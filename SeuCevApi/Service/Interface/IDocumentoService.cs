using SeuCevApi.Model;
using static SeuCevApi.Dto.DocumentoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IDocumentoService
    {
        public Task Save(DocumentCreationDto dto);
        public Task Delete(int id);
        public Task Edit(DocumentUpdateDto dto, int id);
        public IEnumerable<Documento> GetAll();
        public Documento GetById(int id);
    }
}
