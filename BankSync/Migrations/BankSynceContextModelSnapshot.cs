﻿// <auto-generated />
using System;
using BankSynce.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankSynce.Migrations
{
    [DbContext(typeof(BankSynceContext))]
    partial class BankSynceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BankSynce.Entities.Banco", b =>
                {
                    b.Property<int>("IdBanco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdBanco"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("IdBanco");

                    b.ToTable("Banco");
                });

            modelBuilder.Entity("BankSynce.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCliente"));

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BankSynce.Entities.Conta", b =>
                {
                    b.Property<int>("IdConta")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdBanco")
                        .HasColumnType("integer");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("integer");

                    b.Property<int?>("IdFornecedor")
                        .HasColumnType("integer");

                    b.Property<string>("NumeroAgencia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("NumeroConta")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("numeric");

                    b.HasKey("IdConta");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("BankSynce.Entities.Fornecedor", b =>
                {
                    b.Property<int>("IdFornecedor")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("IdFornecedor");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("BankSynce.Entities.Transacao", b =>
                {
                    b.Property<int>("IdTransacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdTransacao"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("IdContaEntrada")
                        .HasColumnType("integer");

                    b.Property<int>("IdContaSaida")
                        .HasColumnType("integer");

                    b.Property<int>("Valor")
                        .HasColumnType("integer");

                    b.HasKey("IdTransacao");

                    b.HasIndex("IdContaEntrada");

                    b.HasIndex("IdContaSaida");

                    b.ToTable("Transacao");
                });

            modelBuilder.Entity("BankSynce.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("integer");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BankSynce.Entities.Conta", b =>
                {
                    b.HasOne("BankSynce.Entities.Banco", "Banco")
                        .WithMany("Contas")
                        .HasForeignKey("IdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankSynce.Entities.Cliente", "Cliente")
                        .WithMany("Contas")
                        .HasForeignKey("IdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankSynce.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Contas")
                        .HasForeignKey("IdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banco");

                    b.Navigation("Cliente");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("BankSynce.Entities.Fornecedor", b =>
                {
                    b.HasOne("BankSynce.Entities.Cliente", "Cliente")
                        .WithMany("Fornecedores")
                        .HasForeignKey("IdFornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BankSynce.Entities.Transacao", b =>
                {
                    b.HasOne("BankSynce.Entities.Conta", "ContaEntrada")
                        .WithMany("TransacaoEntrada")
                        .HasForeignKey("IdContaEntrada")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BankSynce.Entities.Conta", "ContaSaida")
                        .WithMany("TransacaoSaida")
                        .HasForeignKey("IdContaSaida")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ContaEntrada");

                    b.Navigation("ContaSaida");
                });

            modelBuilder.Entity("BankSynce.Entities.Usuario", b =>
                {
                    b.HasOne("BankSynce.Entities.Cliente", "Cliente")
                        .WithOne("Usuario")
                        .HasForeignKey("BankSynce.Entities.Usuario", "IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BankSynce.Entities.Banco", b =>
                {
                    b.Navigation("Contas");
                });

            modelBuilder.Entity("BankSynce.Entities.Cliente", b =>
                {
                    b.Navigation("Contas");

                    b.Navigation("Fornecedores");

                    b.Navigation("Usuario")
                        .IsRequired();
                });

            modelBuilder.Entity("BankSynce.Entities.Conta", b =>
                {
                    b.Navigation("TransacaoEntrada");

                    b.Navigation("TransacaoSaida");
                });

            modelBuilder.Entity("BankSynce.Entities.Fornecedor", b =>
                {
                    b.Navigation("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}
