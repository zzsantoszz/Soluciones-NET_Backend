//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clase03.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ContactoCliente
    {
        public int idContactabilidad { get; set; }
        public int idColaborador { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }
        public System.DateTime fechaContactoCliente { get; set; }
        public string comentarioContactoCliente { get; set; }
        public string estadoContactoCliente { get; set; }
    
        public virtual tb_Cliente tb_Cliente { get; set; }
        public virtual tb_Colaborador tb_Colaborador { get; set; }
        public virtual tb_Producto tb_Producto { get; set; }
    }
}
