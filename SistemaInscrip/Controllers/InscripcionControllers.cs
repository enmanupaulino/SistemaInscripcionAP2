using Microsoft.EntityFrameworkCore;
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
            EstudianteControllers estudianteControllers = new EstudianteControllers();
            bool paso = false;
            try
            {
                Estudiantes estudiantes = estudianteControllers.Buscar(inscripciones.EstudianteId);

                estudiantes.Balance += inscripciones.Balance;
                estudianteControllers.Modificar(estudiantes);
                db.inscripciones.Add(inscripciones);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;

        }
        public bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            EstudianteControllers controller = new EstudianteControllers();
            try
            {
                var anterior = Buscar(inscripciones.InscripcionId);

                foreach (var asignatura in inscripciones.Detalle)
                {
                    if (asignatura.Id == 0)
                    {
                        db.Entry(asignatura).State = EntityState.Added;
                    }

                }

                foreach (var asignatura in anterior.Detalle)
                {
                    if (!inscripciones.Detalle.Any(A => A.AsignaturaId == asignatura.AsignaturaId))
                    {
                        db.Entry(asignatura).State = EntityState.Deleted;
                    }
                }

                Estudiantes tempEstudiante = controller.Buscar(inscripciones.EstudianteId);
                Inscripciones inscripcion = Buscar(inscripciones.InscripcionId);

                decimal nuevoBalance = tempEstudiante.Balance -= inscripcion.Balance;
                tempEstudiante.Balance = nuevoBalance + inscripciones.Balance;
                controller.Modificar(tempEstudiante);
                db.inscripciones.Add(inscripcion);
                db.Entry(inscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
       public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Inscripciones inscripcion = new Inscripciones();
            EstudianteControllers controller = new EstudianteControllers();
            try
            {
                
                
                inscripcion = db.inscripciones.Find(Id);
                if (inscripcion != null)
                {
                    Estudiantes tempEstudiante = controller.Buscar(inscripcion.EstudianteId);
                    tempEstudiante.Balance -= inscripcion.Balance;
                    controller.Modificar(tempEstudiante);

                    db.Entry(inscripcion).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }else
                {
                    paso = false;
                }
               
                
              
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        public Inscripciones Buscar(int Id)
        {
            Contexto db = new Contexto();
            Inscripciones inscripcion = new Inscripciones();
            try
            {
                inscripcion = db.inscripciones.Where(i => i.InscripcionId ==  Id).Include(a => a.Detalle).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
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
