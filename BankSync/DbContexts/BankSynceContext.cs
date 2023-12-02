using Microsoft.EntityFrameworkCore;
using BankSynce.Entities;
using System.Reflection.Emit;
using System.Net;
namespace BankSynce.DbContexts
{
    public class BankSynceContext : DbContext
    {
        public DbSet<OCS_CONTA> OCS_CONTA { get; set; } = null!;
        public DbSet<OCS_TRANSACOES> OCS_TRANSACOES { get; set; } = null!;
        public DbSet<PES_FORNECEDOR> PES_FORNECEDOR { get; set; } = null!;
        public DbSet<TAB_BANCO> TAB_BANCO { get; set; } = null!;
        public DbSet<USER_USUARIO> USER_USUARIO { get; set; } = null!;

        public BankSynceContext(DbContextOptions<BankSynceContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var conta = modelBuilder.Entity<OCS_CONTA>();
            conta
                .ToTable("OCS_CONTA");

            conta
                .Property(p => p.NR_CONTA)
                .HasMaxLength(30)
                .IsRequired();
            conta
                .Property(p => p.NR_AGENCIA)
                .HasMaxLength(10)
                .IsRequired();

            conta
                .Property(p => p.VL_SALDO)
                .HasMaxLength(20)
                .IsRequired();
            conta
                .HasOne(c => c.USUARIO)
                .WithOne(a => a.OCS_CONTA)
                .HasForeignKey<OCS_CONTA>(c => c.CD_USUARIO);

            var usuario = modelBuilder.Entity<USER_USUARIO>();

            usuario
                .Property(p => p.NM_PESSOA)
                .HasMaxLength(100)
                .IsRequired();
            usuario
                .Property(p => p.DS_SENHA)
                .HasMaxLength(30)
                .IsRequired();

            usuario
                .Property(p => p.DS_EMAIL)
                .HasMaxLength(50)
                .IsRequired();
            usuario
                .HasMany(o => o.CONTAS)
                .WithOne(s => s.Orders)
                .UsingEntity<OrderService>(os => os.ToTable("OrdersServices")
                .Property(oss => oss.CreatedAt).HasDefaultValueSql("NOW()")
            );

            var fornecedor = modelBuilder.Entity<PES_FORNECEDOR>();
            fornecedor
                .Property(p => p.NM_FORNECEDOR)
                .HasMaxLength(50)
                .IsRequired();
            fornecedor
                .Property(p => p.)
                .HasMaxLength(50)
                .IsRequired();

        }



    }
}

   
