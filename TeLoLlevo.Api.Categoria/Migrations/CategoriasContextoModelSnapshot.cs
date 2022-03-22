﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeLoLlevo.Api.Categoria.Persistencia;

namespace TeLoLlevo.Api.Categoria.Migrations
{
    [DbContext(typeof(CategoriasContexto))]
    partial class CategoriasContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TeLoLlevo.Api.Categoria.Modelo.Categorias", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("FkCategory")
                        .HasColumnType("text");

                    b.Property<bool>("IsMaster")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
