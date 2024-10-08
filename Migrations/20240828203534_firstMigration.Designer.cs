﻿// <auto-generated />
using System;
using EstruturaDoProduto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstruturaDoProduto.Migrations
{
    [DbContext(typeof(EstruturaDoProdutoContext))]
    [Migration("20240828203534_firstMigration")]
    partial class firstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EstruturaDoProduto.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("CodigoProdutoFornecedor")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<decimal>("CustoPadrao")
                        .HasColumnType("decimal(8,4)");

                    b.Property<DateTime?>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MargemDeLucroEmReais")
                        .HasColumnType("decimal(8,4)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("PesoBruto")
                        .HasColumnType("decimal(8,3)");

                    b.Property<decimal?>("PesoLiquido")
                        .HasColumnType("decimal(8,3)");

                    b.Property<decimal>("PrecoFinal")
                        .HasColumnType("decimal(8,4)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
