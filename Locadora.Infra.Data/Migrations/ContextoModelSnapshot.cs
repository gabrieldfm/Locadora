﻿// <auto-generated />
using System;
using Locadora.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locadora.Infra.Data.Migrations
{
    [DbContext(typeof(Contexto.Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Locadora.Dominio.Entidades.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Ativo")
                        .HasColumnType("smallint")
                        .HasColumnName("Ativo");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataCriacao");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int?>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.HasIndex("LocacaoId");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("Locadora.Dominio.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Ativo")
                        .HasColumnType("smallint")
                        .HasColumnName("Ativo");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataCriacao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Locadora.Dominio.Entidades.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfCliente")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("CpfCliente");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataLocacao");

                    b.HasKey("Id");

                    b.ToTable("Locacao");
                });

            modelBuilder.Entity("Locadora.Dominio.Entidades.Filme", b =>
                {
                    b.HasOne("Locadora.Dominio.Entidades.Genero", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.Dominio.Entidades.Locacao", "Locacao")
                        .WithMany("Filmes")
                        .HasForeignKey("LocacaoId");

                    b.Navigation("Genero");

                    b.Navigation("Locacao");
                });

            modelBuilder.Entity("Locadora.Dominio.Entidades.Genero", b =>
                {
                    b.Navigation("Filmes");
                });

            modelBuilder.Entity("Locadora.Dominio.Entidades.Locacao", b =>
                {
                    b.Navigation("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}