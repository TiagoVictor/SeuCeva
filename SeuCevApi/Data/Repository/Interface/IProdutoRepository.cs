using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IProdutoRepository
    {
        public Task SaveAsync(Produto produto);
        public Task DeleteAsync(Produto produto);
        public Task EditAsync(Produto produto);
        public IEnumerable<Produto> GetAll();
        public Produto GetById(int id);
    }
}
