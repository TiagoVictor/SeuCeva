using SeuCevApi.Model;
using static SeuCevApi.Dto.EnderecoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IEnderecoService
    {
        public Task Save(AddresCreationDto dto);
        public Task Delete(AddresCreationDto dto);
        public Task Edit(AddresCreationDto dto);
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(int id);
    }
}
