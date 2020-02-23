using SistemaInscrip.Data;
using SistemaInscrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscrip.Controllers
{
    public class InscripcionControllers
    {

      public bool Insertar(Inscripcion inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.inscripcions.Add(inscripcion);
            paso = db.SaveChanges() > 0;


            return paso;

        }
        public bool Modificar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.inscripcions.Add(inscripcion);
            db.Entry(inscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            paso = db.SaveChanges() > 0;


            return paso;
        }
       public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion();
            inscripcion = db.inscripcions.Find(Id);
            db.Entry(inscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            paso = db.SaveChanges() > 0;


            return paso;
        }
        public Inscripcion Buscar(int Id)
        {
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion();

            inscripcion = db.inscripcions.Find(Id);

            return inscripcion;
        }
        public List<Inscripcion> GetInscripcions(Expression<Func<Inscripcion, bool>> expression)
        {
            List<Inscripcion> lista;
            Contexto db = new Contexto();
            lista = db.inscripcions.Where(expression).ToList();
            return lista;
        }
    }
}
