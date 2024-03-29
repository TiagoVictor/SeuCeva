﻿using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class TipoPlanoRepository : ITipoPlanoRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TipoPlanoRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task DeleteAsync(TipoPlano tipoPlano)
        {
            _applicationDbContext.TiposPlanos.Remove(tipoPlano);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(TipoPlano tipoPlano)
        {
            _applicationDbContext.TiposPlanos.Update(tipoPlano);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<TipoPlano> GetAll()
        {
            return _applicationDbContext.TiposPlanos.Where(x => x.Ativo);
        }

        public TipoPlano GetById(int id)
        {
            return _applicationDbContext.TiposPlanos.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task SaveAsync(TipoPlano tipoPlano)
        {
            await _applicationDbContext.TiposPlanos.AddAsync(tipoPlano);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
