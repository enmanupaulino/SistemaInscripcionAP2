using Microsoft.EntityFrameworkCore;
using SistemaInscrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscrip.Data
{
    public class Contexto :DbContext
    {
        public DbSet<Asignaturas> asignaturas { set; get; }
        public DbSet<Estudiantes> estudiantes { get; set; }
        public DbSet<Pago> pagos { get; set; }
        public DbSet<Inscripcion> inscripcions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@" Data Source=Database/Incripcion.db");
        }

    }
}
