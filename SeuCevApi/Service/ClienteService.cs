using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

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

        public async Task Delete(ClienteDto dto)
        {
            await _clienteRepository.Delete(ConvertToModel(dto));
        }

        public async Task Edit(ClienteDto dto)
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

        public async Task Save(ClienteDto dto)
        {
            await _clienteRepository.Save(ConvertToModel(dto));
            await _emailServiece.SendEmailAsync(dto.Email, "Criação", $"Ola, {dto.Nome} obrigado por cadastrar no SeuCeva!");
        }

        private Cliente ConvertToModel(ClienteDto dto)
        {
            var teste = new Cliente();
            teste.Id = dto.Id;
            teste.Nome = dto.Nome;
            teste.SobreNome = dto.SobreNome;
            teste.Email = dto.Email;
            teste.Idade = dto.Idade;
            teste.DtNascimento = dto.DtNascimento;
            teste.Ativo = dto.Ativo;
            teste.Enderecos.Add(new Endereco
            {
                Pais = dto.EnderecoDto.Pais,
                UF = dto.EnderecoDto.UF,
                Cidade = dto.EnderecoDto.Cidade,
                Rua = dto.EnderecoDto.Rua,
                Bairro = dto.EnderecoDto.Bairro,
                CEP = dto.EnderecoDto.CEP,
                Ativo = dto.EnderecoDto.Ativo
            });
            teste.Documentos.Add(new Documento
            {
                Tipo = dto.DocumentoDto.Tipo,
                Numero = dto.DocumentoDto.Numero,
                Ativo = dto.DocumentoDto.Ativo
            });
            return teste;
        }
    }
}
