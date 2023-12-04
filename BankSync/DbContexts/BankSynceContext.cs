using Microsoft.EntityFrameworkCore;
using BankSynce.Entities;
using System.Reflection.Emit;
using System.Net;
using System.Runtime.InteropServices;
namespace BankSynce.DbContexts
{
    public class BankSynceContext : DbContext
    {
        public DbSet<OCS_CONTA> OCS_CONTA { get; set; }
        public DbSet<OCS_TRANSACOES> OCS_TRANSACOES { get; set; } 
        public DbSet<PES_CLIENTE> PES_CLIENTE {get;set;} 
        public DbSet<PES_FORNECEDOR> PES_FORNECEDOR{get;set;}
        public DbSet<TAB_BANCO> TAB_BANCO { get; set; } 
        public DbSet<USER_USUARIO> USER_USUARIO { get; set; } 

        public BankSynceContext(DbContextOptions<BankSynceContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OCS_CONTA>(entity =>
            {
                // Definindo a chave primária
                entity.HasKey(e => e.CD_CONTA);
                // Configurações das propriedades
                entity.Property(e => e.VL_SALDO).IsRequired();
                entity.Property(e => e.NR_CONTA).IsRequired().HasMaxLength(20);
                entity.Property(e => e.NR_AGENCIA).IsRequired().HasMaxLength(20);
                entity.Property(e => e.DT_CADASTRO).IsRequired();
                entity.Property(e => e.CD_BANCO).IsRequired();
                entity.HasOne(d => d.BANCO)
                    .WithMany(p => p.CONTAS)
                    .HasForeignKey(d => d.CD_BANCO);
                entity.HasOne(d => d.CLIENTE)
                    .WithMany(p => p.CONTAS)
                    .HasForeignKey(d => d.CD_CLIENTE);
                entity.HasOne(d => d.FORNECEDOR)
                    .WithMany(p => p.CONTAS)
                    .HasForeignKey(d => d.CD_FORNECEDOR);
                
            });

            modelBuilder.Entity<USER_USUARIO>(entity =>
            {
                entity.HasKey(e => e.CD_USUARIO);
                entity.Property(e => e.DS_EMAIL).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DS_SENHA).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DT_CADASTRO).IsRequired();
                entity.HasOne(d => d.CLIENTE)
                    .WithOne(p => p.USUARIO)
                    .HasForeignKey<PES_CLIENTE>(d => d.CD_USUARIO);
            });
            modelBuilder.Entity<PES_FORNECEDOR>(entity =>
            {
                entity.HasKey(e => e.CD_FORNECEDOR);
                entity.Property(e => e.NM_FORNECEDOR).IsRequired().HasMaxLength(100);

                entity.HasMany(e => e.CONTAS)
                    .WithOne(e => e.FORNECEDOR)
                    .HasForeignKey(c => c.CD_CONTA);

                entity.HasOne(d => d.CLIENTE)
                    .WithMany(p => p.FORNECEDORES)
                    .HasForeignKey(c => c.CD_CLIENTE);
            });

            // Mapeamento para PES_CLIENTE
            modelBuilder.Entity<PES_CLIENTE>(entity =>
            {
                entity.HasKey(e => e.CD_CLIENTE);

                entity.Property(e => e.NM_CLIENTE).IsRequired().HasMaxLength(100);

                entity.HasOne(d => d.USUARIO)
                    .WithOne(e => e.CLIENTE)
                    .HasForeignKey<USER_USUARIO>(d => d.CD_USUARIO);

                entity.HasMany(d => d.FORNECEDORES)
                    .WithOne(e => e.CLIENTE)
                    .HasForeignKey(d => d.CD_FORNECEDOR); 

                entity.HasMany(e => e.CONTAS)
                    .WithOne(e => e.CLIENTE)
                    .HasForeignKey(c => c.CD_CONTA);
            });
            modelBuilder.Entity<TAB_BANCO>(entity =>
            {
                entity.HasKey(e => e.CD_BANCO); 
                entity.Property(e => e.NM_BANCO)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.HasMany(b => b.CONTAS)
                    .WithOne(d => d.BANCO)
                    .HasForeignKey(c => c.CD_CONTA); // Chave estrangeira em OCS_CONTA
            });
            modelBuilder.Entity<OCS_TRANSACOES>(entity =>
            {
                entity.HasKey(e => e.CD_TRANSACAO); // Chave primária
                entity.Property(e => e.DS_TRANSACAO).IsRequired().HasMaxLength(200);
                entity.Property(e => e.DT_TRANSACAO).IsRequired();
                entity.Property(e => e.VL_TRANSACAO).IsRequired();
                entity.Property(e => e.ID_TRANSACAO).IsRequired();

                entity.HasOne(d => d.CONTA_ENTRADA)
                    .WithMany(d => d.TRANSACOES_ENTRADA)
                    .HasForeignKey(d => d.CD_CONTA_ENTRADA)
                    .OnDelete(DeleteBehavior.Restrict); // Evita a exclusão em cascata

                entity.HasOne(d => d.CONTA_SAIDA)
                    .WithMany(d => d.TRANSACOES_SAIDA)
                    .HasForeignKey(d => d.CD_CONTA_SAIDA)
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

   
