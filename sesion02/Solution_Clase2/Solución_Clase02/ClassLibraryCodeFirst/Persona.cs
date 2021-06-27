using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbPersona")]
    public class Persona
    {
        /*
         * Data Annotations
         */
        [Key]
        public int IdPersona { get; set; }
        
        [Required] // especifica que el campo es requerido
        [StringLength(50)] // especifica el tamaño del camp
        [Column("NombrePersona",TypeName ="Varchar")]
        public string Nombre { get; set; }
        
        public DateTime fechaNacimiento { get; set; }
        
        public int Edad { get; set; }

        //clave foranea
        public int IdTipoDoc { get; set; }
        public  TipoDocumento TipoDocumento { get; set; }
    }
}
