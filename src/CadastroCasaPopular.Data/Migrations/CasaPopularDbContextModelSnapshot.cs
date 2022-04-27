﻿// <auto-generated />
using System;
using CadastroCasaPopular.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroCasaPopular.Data.Migrations
{
    [DbContext(typeof(CasaPopularDbContext))]
    partial class CasaPopularDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("CasaPopular.Api.Model.Familia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mae")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pai")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("RendaFamiliar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Familias");
                });

            modelBuilder.Entity("CasaPopular.Domain.Model.Filho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FamiliaId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FamiliaId");

                    b.ToTable("Filhos");
                });

            modelBuilder.Entity("CasaPopular.Domain.Model.Filho", b =>
                {
                    b.HasOne("CasaPopular.Api.Model.Familia", null)
                        .WithMany("Filhos")
                        .HasForeignKey("FamiliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}