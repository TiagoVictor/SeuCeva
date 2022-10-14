using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class DocumentoRepository : IDocumentoRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DocumentoRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task DeleteAsync(Documento documento)
        {
            _applicationDbContext.Documentos.Remove(documento);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Documento documento)
        {
            _applicationDbContext.Documentos.Update(documento);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<Documento> GetAll()
        {
            return _applicationDbContext.Documentos.Where(x => x.Ativo);
        }

        public Documento GetById(int id)
        {
            return _applicationDbContext.Documentos.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task SaveAsync(Documento documento)
        {
            await _applicationDbContext.Documentos.AddAsync(documento);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
