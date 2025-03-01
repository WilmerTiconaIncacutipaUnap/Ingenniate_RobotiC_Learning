﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaJapSoftware.Shared
{
    public class Curso
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* El campo Nombre  es obligatorio")]
        public string NombreCurso { get; set; }

        [Required(ErrorMessage = "* El campo Descripcion  es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "* El campo Ruta Imagen es obligatorio")]
        public string RutaImagen { get; set; }

        [Required(ErrorMessage = "* El campo Fecha Inicio es obligatorio")]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = "* El campo Programa es obligatorio")]
        public string Programa { get; set; }

        [Required(ErrorMessage = "* El campo fecha Fin es obligatorio")]
        public DateTime FechaBaja { get; set; }

        public Precio Precio { get; set; }

        public Error error { get; set; }
    }
}
