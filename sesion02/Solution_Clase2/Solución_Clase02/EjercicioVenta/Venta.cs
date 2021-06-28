using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    [Table("tbVenta")]
    public class Venta
    {
        /*
         * Data Annotations
         */
        [Key]
        public int IdVenta { get; set; }
        public DateTime FechaRegistro { get; set; }

        //clave foranea
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; }
    }
}
