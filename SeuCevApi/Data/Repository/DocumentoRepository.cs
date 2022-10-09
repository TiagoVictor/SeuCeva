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

        public async Task Delete(Documento documento)
        {
            _applicationDbContext.Documentos.Remove(documento);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task Edit(Documento documento)
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

        public async Task Save(Documento documento)
        {
            documento.RegistrationDate = DateTime.UtcNow;
            await _applicationDbContext.Documentos.AddAsync(documento);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
