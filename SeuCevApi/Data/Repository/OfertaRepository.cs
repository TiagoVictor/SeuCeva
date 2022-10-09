using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class OfertaRepository : IOfertaRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OfertaRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Delete(Oferta oferta)
        {
            _applicationDbContext.Ofertas.Remove(oferta);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task Edit(Oferta oferta)
        {
            _applicationDbContext.Ofertas.Update(oferta);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<Oferta> GetAll()
        {
            return _applicationDbContext.Ofertas.Where(x => x.Ativo);
        }

        public Oferta GetById(int id)
        {
            return _applicationDbContext.Ofertas.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task Save(Oferta oferta)
        {
            await _applicationDbContext.Ofertas.AddAsync(oferta);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
