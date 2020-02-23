﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscrip.Models
{
    public class Pago
    {
        [Key]
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public int InscripcionId { get; set; }
        public decimal Monto { get; set; }
        public Pago()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            InscripcionId = 0;
            Monto = 0;

        }
    }
}
