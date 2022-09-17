using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IDocumentoService
    {
        public Task Save(Documento documento);
        public Task Delete(Documento documento);
        public Task Edit(Documento documento);
        public IQueryable<Documento> GetAll();
        public Documento GetById(int id);
    }
}
