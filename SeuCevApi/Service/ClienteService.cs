using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.ClienteDto;

namespace SeuCevApi.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailServiece;

        public ClienteService(IClienteRepository clienteRepository, IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _emailServiece = emailService;
        }

        public async Task Delete(ClientCreationDto dto)
        {
            await _clienteRepository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(ClientCreationDto dto)
        {
            await _clienteRepository.Edit(ConvertToModel(dto));
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();

        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public async Task Save(ClientCreationDto dto)
        {
            await _clienteRepository.Save(ConvertToModel(dto));
            await _emailServiece.SendEmailAsync(dto.Email, "Criação", $"Ola, {dto.Nome} obrigado por cadastrar no SeuCeva!");
        }

        private Cliente ConvertToModel(ClientCreationDto dto)
        {
            return new Cliente
            {
                Nome = dto.Nome,
                SobreNome = dto.SobreNome,
                Email = dto.Email,
                Idade = dto.Idade,
                DtNascimento = dto.DtNascimento,
                Enderecos = {new Endereco
                {
                    Pais = dto.EnderecoDto.Pais,
                    UF = dto.EnderecoDto.UF,
                    Cidade = dto.EnderecoDto.Cidade,
                    Rua = dto.EnderecoDto.Rua,
                    Bairro = dto.EnderecoDto.Bairro,
                    CEP = dto.EnderecoDto.CEP,
                } },
                Documentos = {new Documento
                {
                    Tipo = dto.DocumentoDto.Tipo,
                    Numero = dto.DocumentoDto.Numero,
                } }
            };
        }
    }
}
