using Microsoft.EntityFrameworkCore;
using BankSynce.Entities;
using System.Reflection.Emit;
using System.Net;
using System.Runtime.InteropServices;
namespace BankSynce.DbContexts
{
    public class BankSynceContext : DbContext
    {
        public DbSet<OCS_CONTA> OCS_CONTA { get; set; } = null!;
        public DbSet<OCS_TRANSACOES> OCS_TRANSACOES { get; set; } = null!;
        public DbSet<PES_PESSOA> PES_PESSOA { get; set; } = null!;
        public DbSet<PES_CLIENTE> PES_CLIENTE {get;set;} 
        public DbSet<PES_FORNECEDOR> PES_FORNECEDOR{get;set;}
        public DbSet<TAB_BANCO> TAB_BANCO { get; set; } = null!;
        public DbSet<USER_USUARIO> USER_USUARIO { get; set; } = null!;

        public BankSynceContext(DbContextOptions<BankSynceContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<OCS_CONTA>(entity =>
            {
                entity.HasKey(e => e.CD_CONTA);
                entity.Property(e => e.VL_SALDO).IsRequired(); 
                entity.Property(e => e.NR_CONTA).IsRequired().HasMaxLength(20); 
                entity.Property(e => e.NR_AGENCIA).IsRequired().HasMaxLength(20);
                entity.Property(e => e.DT_CADASTRO).IsRequired();
                entity.Property(e => e.CD_BANCO).IsRequired();
                entity.Property(e => e.CD_PESSOA).IsRequired(); 
                entity.HasOne(d => d.BANCO)
                    .WithMany(p => p.CONTAS)
                    .HasForeignKey(d => d.CD_BANCO);

                entity.HasOne(d => d.PESSOA)
                    .WithMany(p => p.CONTAS)
                    .HasForeignKey(d => d.CD_PESSOA);
            });
        modelBuilder.Entity<USER_USUARIO>(entity =>
        {
            entity.HasKey(e => e.CD_USUARIO);
            entity.Property(e => e.DS_EMAIL).IsRequired().HasMaxLength(100);
            entity.Property(e => e.DS_SENHA).IsRequired().HasMaxLength(100);
            entity.Property(e => e.DT_CADASTRO).IsRequired();
            entity.HasOne(d => d.PESSOA)
            .WithOne(p => p.USUARIO)
            .HasForeignKey(d => d.CD_PESSOA);
        });
            

        }



    }
}

   
