using SeuCevApi.Data.Repository.Interface;
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

        public async Task DeleteAsync(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _clienteRepository.DeleteAsync(model);
        }

        public async Task EditAsync(ClientUpdateDto dto, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado");

            await _clienteRepository.EditAsync(ConvertToModelUpdate(dto, model));
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();

        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public Task<bool> HasCreated(LoginDto cliente)
        {
            return _clienteRepository.HasCreated(ConvertToModelLogin(cliente));
        }

        public async Task SaveAsync(ClientCreationDto dto)
        {
            await _clienteRepository.SaveAsync(ConvertToModelCreation(dto));
            await _emailServiece.SendEmailAsync(dto.Email, "Criação", $"Ola, {dto.Nome} obrigado por cadastrar no SeuCeva!");
        }

        private Cliente ConvertToModelCreation(ClientCreationDto dto)
        {
            return new Cliente
            {
                Nome = dto.Nome,
                SobreNome = dto.SobreNome,
                Email = dto.Email,
                PassWord = dto.Password,
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

        private Cliente ConvertToModelUpdate(ClientUpdateDto dto, Cliente model)
        {
            model.Nome = dto.Nome;
            model.SobreNome = dto.SobreNome;
            model.Email = dto.Email;
            model.PassWord = dto.Password;
            model.Idade = dto.Idade;
            model.DtNascimento = dto.DtNascimento;
            model.Enderecos
                .Add(new Endereco
                {
                    Pais = dto.EnderecoDto.Pais,
                    UF = dto.EnderecoDto.UF,
                    Cidade = dto.EnderecoDto.Cidade,
                    Rua = dto.EnderecoDto.Rua,
                    Bairro = dto.EnderecoDto.Bairro,
                    CEP = dto.EnderecoDto.CEP
                });
            model.Documentos
                .Add(new Documento
                {
                    Tipo = dto.DocumentoDto.Tipo,
                    Numero = dto.DocumentoDto.Numero,
                });

            return model;
        }

        private Cliente ConvertToModelLogin(LoginDto dto)
        {
            return new Cliente
            {
                Email = dto.Login,
                PassWord = dto.Password
            };
        }
    }
}
