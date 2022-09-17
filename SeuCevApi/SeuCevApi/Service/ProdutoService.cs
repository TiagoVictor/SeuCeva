using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Delete(Produto produto)
        {
            await _produtoRepository.Delete(produto);
        }

        public async Task Edit(Produto produto)
        {
            await _produtoRepository.Edit(produto);
        }

        public IQueryable<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public Produto GetById(int id)
        {
            return _produtoRepository.GetById(id);
        }

        public async Task Save(Produto produto)
        {
            await _produtoRepository.Save(produto);
        }
    }
}
