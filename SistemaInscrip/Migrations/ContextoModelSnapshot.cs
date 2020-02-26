﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaInscrip.Data;

namespace SistemaInscrip.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("SistemaInscrip.Models.Asignaturas", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Codigo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Creditos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prerequisito")
                        .HasColumnType("TEXT");

                    b.HasKey("AsignaturaId");

                    b.ToTable("asignaturas");
                });

            modelBuilder.Entity("SistemaInscrip.Models.Estudiantes", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("EstudianteId");

                    b.ToTable("estudiantes");
                });

            modelBuilder.Entity("SistemaInscrip.Models.Inscripciones", b =>
                {
                    b.Property<int>("InscripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Balance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Disponible")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Limite")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Semestre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tomado")
                        .HasColumnType("INTEGER");

                    b.HasKey("InscripcionId");

                    b.ToTable("inscripciones");
                });

            modelBuilder.Entity("SistemaInscrip.Models.Pago", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("InscripcionId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("PagoId");

                    b.ToTable("pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
