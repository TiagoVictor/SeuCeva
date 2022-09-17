using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IEnderecoService
    {
        public Task Save(Endereco endereco);
        public Task Delete(Endereco endereco);
        public Task Edit(Endereco endereco);
        public IQueryable<Endereco> GetAll();
        public Endereco GetById(int id);
    }
}
