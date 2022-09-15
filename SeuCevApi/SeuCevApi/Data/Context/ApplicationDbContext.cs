using Microsoft.EntityFrameworkCore;
using SeuCevApi.Model;

namespace SeuCevApi.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoCliente> TiposClientes { get; set; }
        public DbSet<TipoPlano> TiposPlanos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Nome);
                p.Property(x => x.SobreNome);
                p.Property(x => x.Idade);
                p.Property(x => x.Email);
                p.Property(x => x.DtNascimento);
                p.Property(x => x.Documento);
                p.Property(x => x.Endereco);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

            });

            modelBuilder.Entity<Documento>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Tipo);
                p.Property(x => x.Numero);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Endereco>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Pais);
                p.Property(x => x.UF);
                p.Property(x => x.Cidade);
                p.Property(x => x.Bairro);
                p.Property(x => x.Rua);
                p.Property(x => x.CEP);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Oferta>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Titulo);
                p.Property(x => x.Descricao);
                p.Property(x => x.Quantidade);
                p.Property(x => x.Alcance);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Produto>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Descricao);
                p.Property(x => x.Nome);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);
            });

            modelBuilder.Entity<TipoCliente>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Descricao);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);
            });

            modelBuilder.Entity<TipoPlano>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Descricao);
                p.Property(x => x.Ativo);
                p.HasKey (x => x.Id);
            });
        }
    }
}
