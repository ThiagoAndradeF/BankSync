using Microsoft.EntityFrameworkCore;
using BankSynce.Entities;
using System.Reflection.Emit;
using System.Net;
using System.Runtime.InteropServices;
namespace BankSynce.DbContexts
{
    public class BankSynceContext : DbContext
    {
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Transacao> Transacao { get; set; } 
        public DbSet<Cliente> Cliente {get;set;} 
        public DbSet<Fornecedor> Fornecedor {get;set;}
        public DbSet<Usuario> Usuario { get; set; } 

        public BankSynceContext(DbContextOptions<BankSynceContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conta>(entity =>
            {
                // Definindo a chave primária
                entity.HasKey(e => e.IdConta);
                // Configurações das propriedades
                entity.Property(e => e.Saldo).IsRequired();
                entity.Property(e => e.NumeroConta).IsRequired().HasMaxLength(20);
                entity.Property(e => e.NumeroAgencia).IsRequired().HasMaxLength(20);
                entity.Property(e => e.DataCadastro);
                entity.Property(e => e.NomeBanco).IsRequired().HasMaxLength(50);
                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.IdCliente);
                entity.HasOne(d => d.Fornecedor)
                    .WithMany(p => p.Contas)
                    .HasForeignKey(d => d.IdFornecedor);
                
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DataCadastro).IsRequired();
                entity.HasOne(d => d.Cliente)
                    .WithOne(p => p.Usuario)
                    .HasForeignKey<Cliente>(d => d.IdCliente);
            });
            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Telefone).HasMaxLength(100);

                entity.HasMany(e => e.Contas)
                    .WithOne(e => e.Fornecedor)
                    .HasForeignKey(c => c.IdConta);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Fornecedores)
                    .HasForeignKey(c => c.IdCliente);
            });

            // Mapeamento para PES_CLIENTE
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);

                entity.HasMany(d => d.Fornecedores)
                    .WithOne(e => e.Cliente)
                    .HasForeignKey(d => d.IdFornecedor); 

                entity.HasMany(e => e.Contas)
                    .WithOne(e => e.Cliente)
                    .HasForeignKey(c => c.IdConta);
            });
            modelBuilder.Entity<Transacao>(entity =>
            {
                entity.HasKey(e => e.IdTransacao); // Chave primária
                entity.Property(e => e.Descricao).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Data);
                entity.Property(e => e.Valor).IsRequired();

                entity.HasOne(d => d.ContaEntrada)
                    .WithMany(d => d.TransacaoEntrada)
                    .HasForeignKey(d => d.IdContaEntrada)
                    .OnDelete(DeleteBehavior.Restrict); // Evita a exclusão em cascata

                entity.HasOne(d => d.ContaSaida)
                    .WithMany(d => d.TransacaoSaida)
                    .HasForeignKey(d => d.IdContaSaida)
                    .OnDelete(DeleteBehavior.Restrict); // Evita a exclusão em cascata

                // entity.HasOne(d => d.CLIENTE)
                //     .WithMany(c =>c.TRANSACOES)
                //     .HasForeignKey(d => d.CD_CLIENTE);

                // entity.HasOne(d => d.FORNECEDOR)
                //     .WithMany(d => d.TRANSACOES)
                //     .HasForeignKey(d => d.CD_FORNECEDOR);
            });
        base.OnModelCreating(modelBuilder);
        }
    }
}

   
