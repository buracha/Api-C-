﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240129175518_Primeiro")]
    partial class Primeiro
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApi.Model.Cliente", b =>
                {
                    b.Property<int>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    b.Property<int>("Cpf")
                        .HasColumnType("int")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.Property<int>("Telefone")
                        .HasColumnType("int")
                        .HasColumnName("telefone");

                    b.HasKey("Id_cliente");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id_cliente = 1,
                            Cpf = 1234,
                            Email = "jadson@gmail.com",
                            Name = "jadson",
                            Senha = "123",
                            Telefone = 8898808
                        },
                        new
                        {
                            Id_cliente = 2,
                            Cpf = 4321,
                            Email = "jadson1@gmail.com",
                            Name = "jad",
                            Senha = "321",
                            Telefone = 8899908
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
