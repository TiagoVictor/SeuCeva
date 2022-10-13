using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.EnderecoDto;

namespace SeuCevApi.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task Delete(AddresCreationDto dto)
        {
            await _enderecoRepository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(AddresCreationDto dto)
        {
            await _enderecoRepository.Edit(ConvertToModel(dto));
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoRepository.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _enderecoRepository.GetById(id);
        }

        public async Task Save(AddresCreationDto dto)
        {
            await _enderecoRepository.Save(ConvertToModel(dto));
        }

        public Endereco ConvertToModel(AddresCreationDto dto)
        {
            return new Endereco
            {
                Pais = dto.Pais,
                UF = dto.UF,
                Cidade = dto.Cidade,
                Rua = dto.Rua,
                Bairro = dto.Bairro,
                CEP = dto.CEP
            };
        }
    }
}
