﻿using System;
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
        public int Matricula { get; set; }
        public string Nombres { get; set; }
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
