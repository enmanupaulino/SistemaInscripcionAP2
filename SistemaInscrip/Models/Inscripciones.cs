using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscrip.Models
{
    public class Inscripciones
    {
        [Key]

        public int InscripcionId { get; set; }
        [Required(ErrorMessage ="Debe de tener un semestre")]
        public string Semestre { get; set; }
        [Required(ErrorMessage ="Debe de haber un limite")]
        public int  Limite { get; set; }
        [Required(ErrorMessage ="Debe de haber un Monto")]
        public int Tomado { get; set; }
        public int Disponible { get; set; }
        public DateTime  Fecha { get; set; }
        [Required(ErrorMessage ="Debe de tener algun balance")]
        public int Balance { get; set; }
        [Required(ErrorMessage = "Debe de haber un Monto")]
        public int Monto { get; set; }
        [Required(ErrorMessage = "Debe de un Id")]
        public int EstudianteId { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomado = 0;
            Disponible = 0;
            Fecha = DateTime.Now;
            Balance = 0;
            Monto = 0;
            EstudianteId = 0;
        }
    }
}
