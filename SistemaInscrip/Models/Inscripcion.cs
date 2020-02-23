using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscrip.Models
{
    public class Inscripcion
    {
        [Key]

        public int InscripcionId { get; set; }
        public string Semestre { get; set; }
        public int  Limite { get; set; }
        public int Tomado { get; set; }
        public int Disponible { get; set; }
        public DateTime  Fecha { get; set; }
        public int Balance { get; set; }
        public int Monto { get; set; }
        public int EstudianteId { get; set; }

        public Inscripcion()
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
