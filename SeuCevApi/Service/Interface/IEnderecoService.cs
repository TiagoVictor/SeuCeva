using SeuCevApi.Model;
using static SeuCevApi.Dto.EnderecoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IEnderecoService
    {
        public Task SaveAsync(AddresCreationDto dto);
        public Task DeleteAsync(int id);
        public Task EditAsync(AddresUpdateDto dto, int id);
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(int id);
    }
}
