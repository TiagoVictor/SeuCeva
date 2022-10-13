using SeuCevApi.Model;
using static SeuCevApi.Dto.ProdutoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IProdutoService
    {
        public Task Save(ProductCreationDto produto);
        public Task Delete(int id);
        public Task Edit(ProductUpdateDto produto, int id);
        public IEnumerable<Produto> GetAll();
        public Produto GetById(int id);
    }
}
