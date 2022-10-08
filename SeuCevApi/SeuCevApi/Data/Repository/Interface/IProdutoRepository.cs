using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository.Interface
{
    public interface IProdutoRepository
    {
        public Task Save(Produto produto);
        public Task Delete(Produto produto);
        public Task Edit(Produto produto);
        public IQueryable<Produto> GetAll();
        public Produto GetById(int id);
    }
}
