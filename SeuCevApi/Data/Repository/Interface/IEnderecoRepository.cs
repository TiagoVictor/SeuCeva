using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IEnderecoRepository
    {
        public Task SaveAsync(Endereco endereco);
        public Task DeleteAsync(Endereco endereco);
        public Task EditAsync(Endereco endereco);
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(int id);
    }
}
