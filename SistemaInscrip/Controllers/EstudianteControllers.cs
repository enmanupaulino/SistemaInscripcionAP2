using SistemaInscrip.Data;
using SistemaInscrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscrip.Controllers
{
    public class EstudianteControllers


    {
        public bool Guardar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            if (estudiantes.EstudianteId == 0)
            {
                paso = Insertar(estudiantes);
            }
            else
            {
                paso = Modificar(estudiantes);
            }
            return paso;
        }
        public bool Insertar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.estudiantes.Add(estudiante);
            paso = db.SaveChanges() > 0;
            return paso;
        }
        public bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Estudiantes estudiantes = new Estudiantes();
            db.estudiantes.Add(estudiantes);
            db.Entry(estudiantes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            paso = db.SaveChanges() > 0;
            return paso;
            
            
            
        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Estudiantes estudiantes = new Estudiantes();
            try
            {
                estudiantes = db.estudiantes.Find(Id);
                db.Entry(estudiantes).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception) { throw; }
            return paso;
        }
        public Estudiantes Buscar (int id)
        {
            Contexto db = new Contexto();
            Estudiantes estudiantes = new Estudiantes();
            try
            {
                estudiantes = db.estudiantes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return estudiantes;
        }
        public List<Estudiantes> GetEstudiantes(Expression<Func<Estudiantes,bool>>expression)
        {
            List <Estudiantes> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.estudiantes.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;


        }
            }
}
