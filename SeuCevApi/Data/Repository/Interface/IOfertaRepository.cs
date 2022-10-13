using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IOfertaRepository
    {
        public Task SaveAsync(Oferta oferta);
        public Task DeleteAsync(Oferta oferta);
        public Task EditAsync(Oferta oferta);
        public IEnumerable<Oferta> GetAll();
        public Oferta GetById(int id);
    }
}
