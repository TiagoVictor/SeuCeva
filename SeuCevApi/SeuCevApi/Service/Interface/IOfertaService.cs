using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IOfertaService
    {
        public Task Save(Oferta oferta);
        public Task Delete(Oferta oferta);
        public Task Edit(Oferta oferta);
        public IQueryable<Oferta> GetAll();
        public Oferta GetById(int id);
    }
}
