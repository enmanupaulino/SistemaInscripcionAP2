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
        [Required(ErrorMessage = "Debe de haber un Codigo")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Debe de haber una Descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Debe de haber un Prerequisito")]
        public string Prerequisito { get; set; }
        [Required(ErrorMessage = "Debe de haber una cantidad de credito")]
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
