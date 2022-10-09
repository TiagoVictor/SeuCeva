using SeuCevApi.Dto;
using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IProdutoService
    {
        public Task Save(ProdutoDto produto);
        public Task Delete(ProdutoDto produto);
        public Task Edit(ProdutoDto produto);
        public IEnumerable<Produto> GetAll();
        public Produto GetById(int id);
    }
}
