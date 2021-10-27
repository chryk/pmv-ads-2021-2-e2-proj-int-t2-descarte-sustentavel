﻿// <auto-generated />
using System;
using DescarteSustentavel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DescarteSustentavel.Migrations
{
    [DbContext(typeof(DescarteSustentavelContext))]
    [Migration("20211023043336_AjustesDeExibicaoCamposItemDescarte")]
    partial class AjustesDeExibicaoCamposItemDescarte
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DescarteSustentavel.Models.ItemDescarte", b =>
                {
                    b.Property<int>("IDItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SolicitacaoDescarteColetaIDSolicitacao")
                        .HasColumnType("int");

                    b.Property<string>("descricaoDoItem")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("tipoDoItem")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("IDItem");

                    b.HasIndex("SolicitacaoDescarteColetaIDSolicitacao");

                    b.ToTable("ItemDescarte");
                });

            modelBuilder.Entity("DescarteSustentavel.Models.SolicitacaoDescarteColeta", b =>
                {
                    b.Property<int>("IDSolicitacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDaSolicitacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDeEncerramento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDDescartador")
                        .HasColumnType("int");

                    b.Property<int>("IDEcoponto")
                        .HasColumnType("int");

                    b.Property<int>("QtdeDeItens")
                        .HasColumnType("int");

                    b.Property<string>("TipoDoMaterial")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("IDSolicitacao");

                    b.ToTable("SolicitacaoDescarteColeta");
                });

            modelBuilder.Entity("DescarteSustentavel.Models.ItemDescarte", b =>
                {
                    b.HasOne("DescarteSustentavel.Models.SolicitacaoDescarteColeta", null)
                        .WithMany("ItensDescarte")
                        .HasForeignKey("SolicitacaoDescarteColetaIDSolicitacao");
                });

            modelBuilder.Entity("DescarteSustentavel.Models.SolicitacaoDescarteColeta", b =>
                {
                    b.Navigation("ItensDescarte");
                });
#pragma warning restore 612, 618
        }
    }
}
