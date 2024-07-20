using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaJapSoftware.Shared
{
    public class Precio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* El campo precio venta es obligatorio")]
        public double PrecioVenta { get; set; }
        
        [Required(ErrorMessage = "* El campo Fecha Inicio es obligatorio")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "* El campo fecha Fin es obligatorio")]
        public DateTime FechaFin { get; set; }
    }
}
