using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IProdutoService
    {
        public Task Save(Produto produto);
        public Task Delete(Produto produto);
        public Task Edit(Produto produto);
        public IQueryable<Produto> GetAll();
        public Produto GetById(int id);
    }
}
