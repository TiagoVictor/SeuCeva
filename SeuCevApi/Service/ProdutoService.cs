using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.ProdutoDto;

namespace SeuCevApi.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Delete(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _produtoRepository.Delete(model);
        }

        public async Task Edit(ProductUpdateDto produto, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _produtoRepository.Edit(ConverToModelUpdate(produto, model));
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public Produto GetById(int id)
        {
            return _produtoRepository.GetById(id);
        }

        public async Task Save(ProductCreationDto dto)
        {
            await _produtoRepository.Save(ConvertToModelCreation(dto));
        }

        private Produto ConvertToModelCreation(ProductCreationDto dto)
        {
            return new Produto
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao,
            };
        }

        private Produto ConverToModelUpdate(ProductUpdateDto dto, Produto model)
        {
            model.Descricao = dto.Descricao;
            model.Ativo = dto.Ativo;

            return model;
        }
    }
}
