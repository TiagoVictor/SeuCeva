using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IDocumentoRepository
    {
        public Task SaveAsync(Documento documento);
        public Task DeleteAsync(Documento documento);
        public Task EditAsync(Documento documento);
        public IEnumerable<Documento> GetAll();
        public Documento GetById(int id);
    }
}
