using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscrip.Models
{
    public class Asignaturas
    {
        

        [Key]
        public int AsignaturaId { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Prerequisito { get; set; }
        public int Creditos  { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            Codigo = 0;
            Descripcion = string.Empty;
            Prerequisito = string.Empty;
            Creditos = 0;
        }
    }
    
}
