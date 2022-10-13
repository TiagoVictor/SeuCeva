using SeuCevApi.Model;
using static SeuCevApi.Dto.EnderecoDto;

namespace SeuCevApi.Service.Interface
{
    public interface IEnderecoService
    {
        public Task Save(AddresCreationDto dto);
        public Task Delete(int id);
        public Task Edit(AddresUpdateDto dto, int id);
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(int id);
    }
}
