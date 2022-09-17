using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task Delete(Endereco endereco)
        {
            await _enderecoRepository.Delete(endereco);
        }

        public async Task Edit(Endereco endereco)
        {
            await _enderecoRepository.Edit(endereco);
        }

        public IQueryable<Endereco> GetAll()
        {
            return _enderecoRepository.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _enderecoRepository.GetById(id);
        }

        public async Task Save(Endereco endereco)
        {
            await _enderecoRepository.Save(endereco);
        }
    }
}
