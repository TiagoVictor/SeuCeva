using SeuCevApi.Model;
using static SeuCevApi.Dto.DocumentoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IDocumentoService
    {
        public Task SaveAsync(DocumentCreationDto dto);
        public Task DeleteAsync(int id);
        public Task EditAsync(DocumentUpdateDto dto, int id);
        public IEnumerable<Documento> GetAll();
        public Documento GetById(int id);
    }
}
