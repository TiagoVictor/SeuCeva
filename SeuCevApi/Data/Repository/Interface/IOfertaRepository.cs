using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IOfertaRepository
    {
        public Task Save(Oferta oferta);
        public Task Delete(Oferta oferta);
        public Task Edit(Oferta oferta);
        public IEnumerable<Oferta> GetAll();
        public Oferta GetById(int id);
    }
}
