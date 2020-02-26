using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaInscrip.Migrations
{
    public partial class CLS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asignaturas",
                columns: table => new
                {
                    AsignaturaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Prerequisito = table.Column<string>(nullable: true),
                    Creditos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asignaturas", x => x.AsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricula = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estudiantes", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "inscripciones",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Semestre = table.Column<string>(nullable: true),
                    Limite = table.Column<int>(nullable: false),
                    Tomado = table.Column<int>(nullable: false),
                    Disponible = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    Monto = table.Column<int>(nullable: false),
                    EstudianteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscripciones", x => x.InscripcionId);
                });

            migrationBuilder.CreateTable(
                name: "pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    InscripcionId = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagos", x => x.PagoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asignaturas");

            migrationBuilder.DropTable(
                name: "estudiantes");

            migrationBuilder.DropTable(
                name: "inscripciones");

            migrationBuilder.DropTable(
                name: "pagos");
        }
    }
}
