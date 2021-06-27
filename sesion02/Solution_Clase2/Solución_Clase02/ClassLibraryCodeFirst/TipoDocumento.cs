using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbTipoDocumento")]
    public class TipoDocumento
    {
        [Key]
        public int IdTipoDoc { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Detalle { get; set; }

        //1 a muchos -> lista de personas -> persona a tipodocumento
        public List<Persona> Personas { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}
