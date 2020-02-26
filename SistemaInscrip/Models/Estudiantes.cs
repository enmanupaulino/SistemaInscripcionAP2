using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscrip.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage = "Debe de haber una Matricula")]
        public int Matricula { get; set; }
        [Required(ErrorMessage = "Debe de tener un nombre")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Debe de haber un Balance")]
        public decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Matricula = 0;
            Nombres = string.Empty;
            Balance = 0;
        }
    }
}
