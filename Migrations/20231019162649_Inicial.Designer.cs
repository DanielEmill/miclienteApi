﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Registro_de_Clientes_y_API.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231019162649_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LimiteCredito")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rnc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ClientesDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("ClienteId");

                    b.ToTable("ClientesDetalle");
                });

            modelBuilder.Entity("ClientesDetalle", b =>
                {
                    b.HasOne("Clientes", null)
                        .WithMany("ClientesDetalle")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clientes", b =>
                {
                    b.Navigation("ClientesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
