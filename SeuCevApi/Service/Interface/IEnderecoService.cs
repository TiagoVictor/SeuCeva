using SeuCevApi.Dto;
using SeuCevApi.Model;

namespace SeuCevApi.Service.Interface
{
    public interface IEnderecoService
    {
        public Task Save(EnderecoDto dto);
        public Task Delete(EnderecoDto dto);
        public Task Edit(EnderecoDto dto);
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(int id);
    }
}
