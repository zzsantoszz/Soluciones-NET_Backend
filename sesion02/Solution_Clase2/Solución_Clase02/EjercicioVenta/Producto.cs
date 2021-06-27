using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    [Table("tbProducto")]
    public class Producto
    {
        /*
         * Data Annotations
         */
        [Key]
        public int IdProducto { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(50)] // especifica el tamaño del camp
        [Column(TypeName = "Varchar")]
        public string NombreProducto { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; }

        //clave foranea
        //public int IdTipoDoc { get; set; }
        //public TipoDocumento TipoDocumento { get; set; }
    }
}
