﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Products_Data;

#nullable disable

namespace Products_Data.Migrations
{
    [DbContext(typeof(ConnectionContext))]
    [Migration("20240317222031_Products")]
    partial class Products
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Products_Domain.Model.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Abacate",
                            Stock = 50m,
                            Value = 5m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Biscoito",
                            Stock = 100m,
                            Value = 5m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Manga",
                            Stock = 80m,
                            Value = 6m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cenoura",
                            Stock = 90m,
                            Value = 4m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Alface",
                            Stock = 30m,
                            Value = 3m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Uva",
                            Stock = 200m,
                            Value = 15m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
