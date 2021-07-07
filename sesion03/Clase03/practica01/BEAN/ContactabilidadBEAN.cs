using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica01.BEAN
{
    /*
     select tcc.idContactabilidad, tco.nombreColaborador, tcl.nombreCliente, tpr.nombreProducto
    from tb_ContactoCliente tcc inner join tb_Colaborador tco
    on tcc.idColaborador = tco.idColaborador
    inner join tb_Cliente tcl
    on tcc.idCliente = tcl.idCliente
    inner join tb_Producto tpr
    on tcc.idProducto = tpr.idProducto; 
     */

    class ContactabilidadBEAN
    {
        public int idContactabilidads { get; set; }
        public string nombreColaboradors { get; set; }
        public string nombreClientes { get; set; }
        public string nombreProductos { get; set; }
    }
}
