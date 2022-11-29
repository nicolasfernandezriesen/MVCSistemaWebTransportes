using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCSistemaWebTransportes.Validations;

namespace MVCSistemaWebTransportes.Models
{
    public class Auto
    {
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        [CheckValidYear]
        public int Año { get; set; }
        [Required]
        public string Color { get; set; }

    }
}