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

        public async Task Delete(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _clienteRepository.Delete(model);
        }

        public async Task Edit(ClientUpdateDto dto, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado");

            await _clienteRepository.Edit(ConvertToModelUpdate(dto, model));
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
            await _clienteRepository.Save(ConvertToModelCreation(dto));
            await _emailServiece.SendEmailAsync(dto.Email, "Criação", $"Ola, {dto.Nome} obrigado por cadastrar no SeuCeva!");
        }

        private Cliente ConvertToModelCreation(ClientCreationDto dto)
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

        private Cliente ConvertToModelUpdate(ClientUpdateDto dto, Cliente model)
        {
            model.Nome = dto.Nome;
            model.SobreNome = dto.SobreNome;
            model.Email = dto.Email;
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
    }
}
