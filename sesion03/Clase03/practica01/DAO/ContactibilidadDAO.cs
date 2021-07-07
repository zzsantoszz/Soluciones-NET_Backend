using practica01.BEAN;
using practica01.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica01.DAO
{
    class ContactibilidadDAO
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
        public void ListaContactibilidad()
        {
            List<ContactabilidadBEAN> listaContactabilidad;
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                var _Datos = from tcc in db.tb_ContactoCliente
                             join tco in db.tb_Colaborador on tcc.idColaborador equals tco.idColaborador
                             join tcl in db.tb_Cliente on tcc.idCliente equals tcl.idCliente
                             join tpr in db.tb_Producto on tcc.idProducto equals tpr.idProducto
                             select new ContactabilidadBEAN
                             {
                                 idContactabilidads = tcc.idContactabilidad,
                                 nombreColaboradors = tco.nombreColaborador,
                                 nombreClientes = tcl.nombreCliente,
                                 nombreProductos = tpr.nombreProducto
  
                             };
                listaContactabilidad = _Datos.ToList();

            }
            Console.Clear();
            Console.WriteLine("Lista de Clientes y Tipo de Documento");
            Console.WriteLine("Id Contactabilidad \t Nombre Colaborador \t Nombre Cliente \t Nombre Producto");
            foreach (var item in listaContactabilidad)
            {
                Console.WriteLine(item.idContactabilidads + "\t\t\t" +
                    item.nombreColaboradors + "\t\t\t" +
                    item.nombreClientes+ "\t\t\t" +
                    item.nombreProductos);
            }

        }
    }
}
