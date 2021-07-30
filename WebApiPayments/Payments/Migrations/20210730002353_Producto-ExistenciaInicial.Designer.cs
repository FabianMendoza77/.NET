﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiPayments;

namespace Payments.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210730002353_Producto-ExistenciaInicial")]
    partial class ProductoExistenciaInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.6.21352.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Payments.Entidades.PedidoDetalle", b =>
                {
                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("PedidoId", "ProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("PedidosDetalle");
                });

            modelBuilder.Entity("WebApiPayments.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WebApiPayments.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("WebApiPayments.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExistenciaInicial")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Payments.Entidades.PedidoDetalle", b =>
                {
                    b.HasOne("WebApiPayments.Entidades.Pedido", "Pedido")
                        .WithMany("Detalle")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiPayments.Entidades.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("WebApiPayments.Entidades.Pedido", b =>
                {
                    b.HasOne("WebApiPayments.Entidades.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("WebApiPayments.Entidades.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("WebApiPayments.Entidades.Pedido", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
