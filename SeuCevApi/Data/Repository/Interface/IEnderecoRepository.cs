using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IEnderecoRepository
    {
        public Task Save(Endereco endereco);
        public Task Delete(Endereco endereco);
        public Task Edit(Endereco endereco);
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(int id);
    }
}
