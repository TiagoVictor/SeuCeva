using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IDocumentoRepository
    {
        public Task Save(Documento documento);
        public Task Delete(Documento documento);
        public Task Edit(Documento documento);
        public IQueryable<Documento> GetAll();
        public Documento GetById(int id);
    }
}
