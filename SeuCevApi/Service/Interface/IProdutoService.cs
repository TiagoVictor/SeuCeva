using SeuCevApi.Model;
using static SeuCevApi.Dto.ProdutoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IProdutoService
    {
        public Task SaveAsync(ProductCreationDto produto);
        public Task DeleteAsync(int id);
        public Task EditAsync(ProductUpdateDto produto, int id);
        public IEnumerable<Produto> GetAll();
        public Produto GetById(int id);
    }
}
