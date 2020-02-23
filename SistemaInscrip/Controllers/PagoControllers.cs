using SistemaInscrip.Data;
using SistemaInscrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscrip.Controllers
{
    public class PagoControllers
    {
        public bool Guardar(Pago pago)
        {
            bool paso = false;
            Contexto db = new Contexto();
            if (pago.PagoId == 0)
            {
                paso = Insertar(pago);
            }
            else
            {
                paso = Modificar(pago);
            }
            return paso;
        }
        public bool Insertar(Pago pago)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.pagos.Add(pago);
            paso = db.SaveChanges() > 0;
            return paso;
        }
        public bool Modificar (Pago pago)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.pagos.Add(pago);
            db.Entry(pago).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            paso = db.SaveChanges() > 0;
            return paso;
            
        }
        public bool Eliminar(int Id)
        {
            Pago pago = new Pago();
            Contexto db = new Contexto();
            bool paso = false;
            pago = db.pagos.Find(Id);
            db.Entry(pago).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            paso = db.SaveChanges() > 0;
            return paso;
        }
        public Pago Buscar(int id)
        {
            Contexto db = new Contexto();
            Pago pago = new Pago();
            try
            {
                pago = db.pagos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return pago;
        }
        public List<Pago> GetEstudiantes(Expression<Func<Pago, bool>> expression)
        {
            List<Pago> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.pagos.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;


        }
    }
}
