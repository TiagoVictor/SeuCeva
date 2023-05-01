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
                p.Property(x => x.Nome).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.SobreNome).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Idade).HasColumnType("VARCHAR(8)").IsRequired();
                p.Property(x => x.Email).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.PassWord).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.DtNascimento);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

                p.HasIndex(x => x.Id).HasDatabaseName("idx_cliente_id");
            });

            modelBuilder.Entity<Documento>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Tipo).HasColumnType("VARCHAR(55)").IsRequired();
                p.Property(x => x.Numero).HasColumnType("VARCHAR(55)").IsRequired();
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

                p.HasIndex(x => x.Id).HasDatabaseName("idx_documento_id");
            });

            modelBuilder.Entity<Endereco>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Pais).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.UF).HasColumnType("VARCHAR(4)").IsRequired();
                p.Property(x => x.Cidade).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Bairro).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Rua).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.CEP).HasColumnType("VARCHAR(8)").IsRequired();
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

                p.HasIndex(x => x.Id).HasDatabaseName("idx_endereco_id");
            });

            modelBuilder.Entity<Oferta>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Titulo).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Descricao).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Quantidade);
                p.Property(x => x.Alcance);
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

                p.HasIndex(x => x.Id).HasDatabaseName("idx_oferta_id");
            });

            modelBuilder.Entity<Produto>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Descricao).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Nome).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

                p.HasIndex(x => x.Id).HasDatabaseName("idx_produto_id");
            });

            modelBuilder.Entity<TipoCliente>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Descricao).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

                p.HasIndex(x => x.Id).HasDatabaseName("idx_tipocliente_id");
            });

            modelBuilder.Entity<TipoPlano>(p =>
            {
                p.Property(x => x.Id);
                p.Property(x => x.Descricao).HasColumnType("VARCHAR(255)").IsRequired();
                p.Property(x => x.Ativo);
                p.HasKey(x => x.Id);

                p.HasIndex(x => x.Id).HasDatabaseName("idx_tipoplano_id");
            });
        }
    }
}
