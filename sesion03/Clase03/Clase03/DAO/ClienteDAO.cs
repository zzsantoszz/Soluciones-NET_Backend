using Clase03.Modelo;
using Clase03.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.DAO
{
    class ClienteDAO
    {

        public void ListaClientesTipoDoc()
        {
            List<ClienteBEAN> listaCliente;
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                var _Datos = from cli in db.tb_Cliente
                             join td in db.tb_TipoDocumento on cli.idTipoDocumento equals td.idTipoDocumento
                             join cat in db.tb_Categoria on cli.idCategoria equals cat.idCategoria
                             select new ClienteBEAN
                             {
                                 idCliente = cli.idCliente,
                                 nombresCliente = cli.nombreCliente,
                                 apellidosCliente = cli.apellidosCliente,
                                 numeroDocumentoCliente = cli.numeroDocumentoCliente,
                                 nombreTipoDocumento = td.nombreTipoDocumento,
                                 nombresCategorias = cat.nombreCategoria
                             };
                listaCliente = _Datos.ToList();

            }
            Console.Clear();
            Console.WriteLine("Lista de Clientes y Tipo de Documento");
            Console.WriteLine("Id \t\t Nombres \t Apellidos \t Num Doc \t Tipo Doc \t\t\t Nombre Categoria");
            foreach (var item in listaCliente)
            {
                Console.WriteLine(item.idCliente + "\t\t" +
                    item.nombresCliente + "\t\t" +
                    item.apellidosCliente + "\t\t" +
                    item.numeroDocumentoCliente + "\t\t" +
                    item.nombreTipoDocumento + "\t\t\t" +
                    item.nombresCategorias);
            }

        }
    }
}
