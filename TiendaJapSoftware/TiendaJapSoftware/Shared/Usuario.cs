﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaJapSoftware.Shared
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* El campo nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "* El campo apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "* El campo Email es obligatorio")]
        [EmailAddress(ErrorMessage = "* Formato de email incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "* El campo password es obligatorio")]
        public string Password { get; set; }

        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public List<Curso> ListaCursos { get; set; }

        public Error error { get; set; }
    }
}
