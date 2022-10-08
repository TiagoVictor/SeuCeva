﻿using Microsoft.EntityFrameworkCore;
using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ClienteRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Delete(Cliente cliente)
        {
            _applicationDbContext.Clientes.Remove(cliente);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task Edit(Cliente cliente)
        {
            _applicationDbContext.Clientes.Update(cliente);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _applicationDbContext.Clientes.Where(x => x.Ativo);
        }

        public Cliente GetById(int id)
        {
            return _applicationDbContext.Clientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task Save(Cliente cliente)
        {
            await _applicationDbContext.Clientes.AddAsync(cliente);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}