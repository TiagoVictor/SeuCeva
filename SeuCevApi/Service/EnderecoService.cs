﻿using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.EnderecoDto;

namespace SeuCevApi.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task Delete(int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _enderecoRepository.Delete(model);
        }

        public async Task Edit(AddresUpdateDto dto, int id)
        {
            var model = GetById(id);

            if (model == null)
                throw new NullReferenceException("Id não encontrado!");

            await _enderecoRepository.Edit(ConvertToModelUpdate(dto, model));
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoRepository.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _enderecoRepository.GetById(id);
        }

        public async Task Save(AddresCreationDto dto)
        {
            await _enderecoRepository.Save(ConvertToModelCreation(dto));
        }

        private Endereco ConvertToModelCreation(AddresCreationDto dto)
        {
            return new Endereco
            {
                Pais = dto.Pais,
                UF = dto.UF,
                Cidade = dto.Cidade,
                Rua = dto.Rua,
                Bairro = dto.Bairro,
                CEP = dto.CEP
            };
        }

        private Endereco ConvertToModelUpdate(AddresUpdateDto dto, Endereco model)
        {
            model.Pais = dto.Pais;
            model.UF = dto.UF;
            model.Cidade = dto.Cidade;
            model.Rua = dto.Rua;
            model.Bairro = dto.Bairro;
            model.CEP = dto.CEP;

            return model;
        }
    }
}
