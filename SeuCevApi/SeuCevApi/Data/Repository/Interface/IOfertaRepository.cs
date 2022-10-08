using SeuCevApi.Model;
using System.ComponentModel.DataAnnotations;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IOfertaRepository
    {
        public Task Save(Oferta oferta);
        public Task Delete(Oferta oferta);
        public Task Edit(Oferta oferta);
        public IQueryable<Oferta> GetAll();
        public Oferta GetById(int id);
    }
}
