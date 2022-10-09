using SeuCevApi.Dto;
using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IDocumentoService
    {
        public Task Save(DocumentoDto dto);
        public Task Delete(DocumentoDto dto);
        public Task Edit(DocumentoDto dto);
        public IEnumerable<Documento> GetAll();
        public Documento GetById(int id);
    }
}
