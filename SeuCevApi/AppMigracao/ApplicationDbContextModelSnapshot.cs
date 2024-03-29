﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SeuCevApi.Data.Context;

#nullable disable

namespace SeuCevApi.AppMigracao
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SeuCevApi.Model.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(8)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_cliente_id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SeuCevApi.Model.Documento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<long>("IdCliente")
                        .HasColumnType("bigint");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("VARCHAR(55)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(55)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_documento_id");

                    b.HasIndex("IdCliente");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("SeuCevApi.Model.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("VARCHAR(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<long>("IdCliente")
                        .HasColumnType("bigint");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(4)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_endereco_id");

                    b.HasIndex("IdCliente");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("SeuCevApi.Model.Oferta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Alcance")
                        .HasColumnType("integer");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_oferta_id");

                    b.ToTable("Ofertas");
                });

            modelBuilder.Entity("SeuCevApi.Model.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_produto_id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SeuCevApi.Model.TipoCliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_tipocliente_id");

                    b.ToTable("TiposClientes");
                });

            modelBuilder.Entity("SeuCevApi.Model.TipoPlano", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("idx_tipoplano_id");

                    b.ToTable("TiposPlanos");
                });

            modelBuilder.Entity("SeuCevApi.Model.Documento", b =>
                {
                    b.HasOne("SeuCevApi.Model.Cliente", "Cliente")
                        .WithMany("Documentos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SeuCevApi.Model.Endereco", b =>
                {
                    b.HasOne("SeuCevApi.Model.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SeuCevApi.Model.Cliente", b =>
                {
                    b.Navigation("Documentos");

                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
