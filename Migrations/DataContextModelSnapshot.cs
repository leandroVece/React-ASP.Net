﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cadeteria;

#nullable disable

namespace cadeteria.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cadeteria.Models.Cadetes", b =>
                {
                    b.Property<Guid>("Id_cadete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_cadete");

                    b.ToTable("Cadete", (string)null);

                    b.HasData(
                        new
                        {
                            Id_cadete = new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc0"),
                            Direccion = "Entre rios",
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Nombre = "Jaun Castellanos",
                            Telefono = "231321231"
                        },
                        new
                        {
                            Id_cadete = new Guid("0a9fa564-0604-4dfa-88df-3636fe395651"),
                            Direccion = "independencia",
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Nombre = "Ana Hume",
                            Telefono = "231321231"
                        },
                        new
                        {
                            Id_cadete = new Guid("0a9fa564-0604-4dfa-88df-3636fe395678"),
                            Direccion = "independencia",
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Nombre = "Fer Hume",
                            Telefono = "654321"
                        });
                });

            modelBuilder.Entity("cadeteria.Models.Clientes", b =>
                {
                    b.Property<Guid>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Referencia")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id_cliente");

                    b.ToTable("Cliente", (string)null);

                    b.HasData(
                        new
                        {
                            Id_cliente = new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc3"),
                            Direccion = "Entre rios",
                            Nombre = "Pancho Castellanos",
                            Telefono = "5231234"
                        },
                        new
                        {
                            Id_cliente = new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc1"),
                            Direccion = "independencia",
                            Nombre = "Lucio Hume",
                            Telefono = "8321156"
                        },
                        new
                        {
                            Id_cliente = new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc5"),
                            Direccion = "independencia",
                            Nombre = "Val Hume",
                            Telefono = "975313"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
