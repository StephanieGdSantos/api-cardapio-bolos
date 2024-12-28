﻿// <auto-generated />
using System;
using CardapioBolos.Banco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace cardapio_bolos.Migrations
{
    [DbContext(typeof(CardapioBolosContext))]
    [Migration("20241228012831_CriaConexaoEntreBolosEEncomendas")]
    partial class CriaConexaoEntreBolosEEncomendas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoloEncomenda", b =>
                {
                    b.Property<int>("BoloId")
                        .HasColumnType("int");

                    b.Property<int>("EncomendaId")
                        .HasColumnType("int");

                    b.HasKey("BoloId", "EncomendaId");

                    b.HasIndex("EncomendaId");

                    b.ToTable("BoloEncomenda");
                });

            modelBuilder.Entity("CardapioBolos.Model.Bolo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Formato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListaIngredientes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Bolos");
                });

            modelBuilder.Entity("CardapioBolos.Model.Encomenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BoloIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDoPedido")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Finalizado")
                        .HasColumnType("bit");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorFinal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Encomendas");
                });

            modelBuilder.Entity("BoloEncomenda", b =>
                {
                    b.HasOne("CardapioBolos.Model.Bolo", null)
                        .WithMany()
                        .HasForeignKey("BoloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CardapioBolos.Model.Encomenda", null)
                        .WithMany()
                        .HasForeignKey("EncomendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}