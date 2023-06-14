﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leiturama.Migrations
{
    [DbContext(typeof(LeituramaContext))]
    partial class LeituramaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Leiturama.Models.Artigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Artigo");
                });

            modelBuilder.Entity("Leiturama.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Leiturama.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Leiturama.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtigoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DtVenda")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Leiturama.Models.Artigo", b =>
                {
                    b.HasOne("Leiturama.Models.Categoria", "Categoria")
                        .WithMany("Artigos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("Leiturama.Models.Genero", "Genero")
                        .WithMany("Artigos")
                        .HasForeignKey("GeneroId");

                    b.Navigation("Categoria");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Leiturama.Models.Categoria", b =>
                {
                    b.Navigation("Artigos");
                });

            modelBuilder.Entity("Leiturama.Models.Genero", b =>
                {
                    b.Navigation("Artigos");
                });
#pragma warning restore 612, 618
        }
    }
}
