using SistemaInscrip.Data;
using SistemaInscrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscrip.Controllers
{
    public class AsignaturaControllers
    {
        public bool Guardar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            if (asignaturas.AsignaturaId == 0)
            {
                paso = Insertar(asignaturas);
            }
            else
            {
                paso = Modificar(asignaturas);
            }
            return paso;
        }
        public bool Insertar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.asignaturas.Add(asignaturas);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception) { throw; }

            return paso;
        }
        public Asignaturas Buscar (int Id)
        {
            Contexto db = new Contexto();
            Asignaturas asignaturas = new Asignaturas();
            try
            {
                asignaturas = db.asignaturas.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            return asignaturas;
        }
        public bool Modificar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.asignaturas.Add(asignaturas);
            db.Entry(asignaturas).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           paso= db.SaveChanges() > 0;

            return paso;
        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Asignaturas asignaturas = new Asignaturas();


            asignaturas= db.asignaturas.Find(Id);
            db.Entry(asignaturas).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            paso = db.SaveChanges() > 0;

            return paso;
        }
        public List<Asignaturas> GetAsignaturas(Expression<Func<Asignaturas,bool>> expression)
        {
            List<Asignaturas> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.asignaturas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
