using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
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

        public async Task Delete(ProdutoDto produto)
        {
            await _produtoRepository.Delete(ConvertToModel(produto));
        }

        public async Task Edit(ProdutoDto produto)
        {
            await _produtoRepository.Edit(ConvertToModel(produto));
        }

        public IQueryable<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public Produto GetById(int id)
        {
            return _produtoRepository.GetById(id);
        }

        public async Task Save(ProdutoDto produto)
        {
            await _produtoRepository.Save(ConvertToModel(produto));
        }

        private Produto ConvertToModel(ProdutoDto dto)
        {
            return new Produto
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Ativo = dto.Ativo
            };
        }
    }
}
