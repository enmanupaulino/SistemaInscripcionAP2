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
        public bool Guardar (Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            if (inscripciones.InscripcionId == 0)
            {
                paso = Insertar(inscripciones);
            }else
            {
                paso = Modificar(inscripciones);
            }
            return paso;
        }
      public bool Insertar(Inscripciones inscripciones)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.inscripciones.Add(inscripciones);
            paso = db.SaveChanges() > 0;


            return paso;

        }
        public bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.inscripciones.Add(inscripcion);
            db.Entry(inscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            paso = db.SaveChanges() > 0;


            return paso;
        }
       public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Inscripciones inscripcion = new Inscripciones();
            inscripcion = db.inscripciones.Find(Id);
            db.Entry(inscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            paso = db.SaveChanges() > 0;


            return paso;
        }
        public Inscripciones Buscar(int Id)
        {
            Contexto db = new Contexto();
            Inscripciones inscripcion = new Inscripciones();

            inscripcion = db.inscripciones.Find(Id);

            return inscripcion;
        }
        public List<Inscripciones> GetInscripcions(Expression<Func<Inscripciones, bool>> expression)
        {
            List<Inscripciones> lista;
            Contexto db = new Contexto();
            lista = db.inscripciones.Where(expression).ToList();
            return lista;
        }
    }
}
