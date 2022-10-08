using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Delete(ClienteDto dto)
        {
            await _clienteRepository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(ClienteDto dto)
        {
            await _clienteRepository.Edit(ConvertToModel(dto));
        }

        public IQueryable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public async Task Save(ClienteDto dto)
        {
            await _clienteRepository.Save(ConvertToModel(dto));
        }

        private Cliente ConvertToModel(ClienteDto dto)
        {
            return new Cliente
            {
                Id = dto.Id,
                Nome = dto.Nome,
                SobreNome = dto.SobreNome,
                Email = dto.Email,
                Idade = dto.Idade,
                DtNascimento = dto.DtNascimento
            };
        }
    }
}
