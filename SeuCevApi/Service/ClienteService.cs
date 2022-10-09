using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IDocumentoService _documentoService;
        private readonly IEnderecoService _enderecoServiece;

        public ClienteService(IClienteRepository clienteRepository, IEnderecoService enderecoServiece, IDocumentoService documentoService)
        {
            _clienteRepository = clienteRepository;
            _enderecoServiece = enderecoServiece;
            _documentoService = documentoService;
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
                DtNascimento = dto.DtNascimento,
                Ativo = dto.Ativo,
                Enderecos = {new Endereco
                {
                    Pais = dto.EnderecoDto.Pais,
                    UF = dto.EnderecoDto.UF,
                    Cidade = dto.EnderecoDto.Cidade,
                    Rua = dto.EnderecoDto.Rua,
                    Bairro = dto.EnderecoDto.Bairro,
                    CEP = dto.EnderecoDto.CEP,
                    Ativo = dto.EnderecoDto.Ativo
                } },
                Documentos = {new Documento
                {
                    Tipo = dto.DocumentoDto.Tipo,
                    Numero = dto.DocumentoDto.Numero,
                    Ativo = dto .DocumentoDto.Ativo
                } }
            };
        }
    }
}
