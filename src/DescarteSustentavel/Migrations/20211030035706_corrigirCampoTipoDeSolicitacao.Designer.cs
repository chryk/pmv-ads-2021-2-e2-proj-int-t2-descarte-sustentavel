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
    [Migration("20211030035706_corrigirCampoTipoDeSolicitacao")]
    partial class corrigirCampoTipoDeSolicitacao
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
                    b.Property<int>("ItemDescarteID")
                        .HasColumnType("int")
                        .HasColumnName("id_item");

                    b.Property<string>("DescricaoDoItem")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("descricao_item");

                    b.Property<int>("SolicitacaoDescarteColetaID")
                        .HasColumnType("int")
                        .HasColumnName("id_solicitacao_descarte_coleta");

                    b.Property<string>("TipoDoItem")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("tipo_item");

                    b.HasKey("ItemDescarteID");

                    b.HasIndex("SolicitacaoDescarteColetaID");

                    b.ToTable("ItemDescarte");
                });

            modelBuilder.Entity("DescarteSustentavel.Models.SolicitacaoDescarteColeta", b =>
                {
                    b.Property<int>("SolicitacaoDescarteColetaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_solicitacao")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDaSolicitacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_solicitacao");

                    b.Property<DateTime?>("DataDeEncerramento")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_encerramento");

                    b.Property<DateTime?>("DataDeEntrega")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_entrega");

                    b.Property<int>("IDDescartador")
                        .HasColumnType("int")
                        .HasColumnName("descartador");

                    b.Property<int>("IDEcoponto")
                        .HasColumnType("int")
                        .HasColumnName("ecoponto");

                    b.Property<int>("QtdeDeItens")
                        .HasColumnType("int")
                        .HasColumnName("qtd_itens");

                    b.Property<string>("TipoDeSolicitacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("tipo_solicitacao");

                    b.Property<string>("TipoDoMaterial")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("tipo_material");

                    b.HasKey("SolicitacaoDescarteColetaID");

                    b.ToTable("SolicitacaoDescarteColeta");
                });

            modelBuilder.Entity("DescarteSustentavel.Models.ItemDescarte", b =>
                {
                    b.HasOne("DescarteSustentavel.Models.SolicitacaoDescarteColeta", "SolicitacaoDescarteColeta")
                        .WithMany("ItensDescarte")
                        .HasForeignKey("SolicitacaoDescarteColetaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SolicitacaoDescarteColeta");
                });

            modelBuilder.Entity("DescarteSustentavel.Models.SolicitacaoDescarteColeta", b =>
                {
                    b.Navigation("ItensDescarte");
                });
#pragma warning restore 612, 618
        }
    }
}
