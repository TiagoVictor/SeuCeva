using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProdutoRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task DeleteAsync(Produto produto)
        {
            _applicationDbContext.Produtos.Remove(produto);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Produto produto)
        {
            _applicationDbContext.Produtos.Update(produto);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<Produto> GetAll()
        {
            return _applicationDbContext.Produtos.Where(x => x.Ativo);
        }

        public Produto GetById(int id)
        {
            return _applicationDbContext.Produtos.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task SaveAsync(Produto produto)
        {
            await _applicationDbContext.AddAsync(produto);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
