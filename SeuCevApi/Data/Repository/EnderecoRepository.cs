using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EnderecoRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task DeleteAsync(Endereco endereco)
        {
            _applicationDbContext.Enderecos.Remove(endereco);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Endereco endereco)
        {
            _applicationDbContext.Enderecos.Update(endereco);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _applicationDbContext.Enderecos.Where(x => x.Ativo);
        }

        public Endereco GetById(int id)
        {
            return _applicationDbContext.Enderecos.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task SaveAsync(Endereco endereco)
        {
            await _applicationDbContext.Enderecos.AddAsync(endereco);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
