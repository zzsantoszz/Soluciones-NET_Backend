using Clase03.BEAN;
using Clase03.DAO;
using Clase03.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lista Cateogira con EF

            //BD_CONTABILIDADEntities conDB = new BD_CONTABILIDADEntities();
            /* 
               List<tb_Categoria> listaCat = new List<tb_Categoria>();
               List<tb_Cliente> lista2Cat = new List<tb_Cliente>();
               using (var db = new BD_CONTACTABILIDADEntities())
               {
                   listaCat = db.tb_Categoria.ToList();
                   lista2Cat = db.tb_Cliente.ToList();
               }
               Console.WriteLine("Lista de Categoria: ");
               foreach (var item in listaCat)
               {
                   Console.WriteLine(item.idCategoria + "" + item.nombreCategoria);
               }
               Console.WriteLine("Lista de Cliente: ");
               foreach (var item2 in lista2Cat)
               {
                   Console.WriteLine(item2.idCliente + "" + item2.nombreCliente);
               }
            */
            #endregion

            #region Registrar Categoria con EF
            /*
            Console.WriteLine("Lista de Categoria: ");
            string nombreCat = Console.ReadLine();
            tb_Categoria cat = new tb_Categoria { nombreCategoria = nombreCat };
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                db.tb_Categoria.Add(cat);
                db.SaveChanges();
            }
            Console.WriteLine("Se ingreso correctamete.");
            */
            #endregion

            #region Categoria con carpeta DAO para llamar
            /*
            CategoriaDAO catDAO = new CategoriaDAO();
            catDAO.RegistrarCategoria();
            catDAO.ListaCategoria();
            */
            #endregion

            CategoriaDAO catDAO = new CategoriaDAO();
            ClienteDAO clienteDAO = new ClienteDAO();
            string rpta = "N";
            int codMenu = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al mantenimiento de Categoria");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("1- Lista.");
                Console.WriteLine("2- Registro.");
                Console.WriteLine("3- Editar.");
                Console.WriteLine("4- Eliminar.");
                Console.WriteLine("5- Consulta.");
                Console.WriteLine("\n0- Salir.");
                Console.WriteLine("Ingrese el codigo del menu: ");
                codMenu = Convert.ToInt32(Console.ReadLine());
                switch (codMenu)
                {
                    case 1:
                        catDAO.ListaCategoria();
                        Console.WriteLine("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 2:
                        catDAO.RegistrarCategoria();
                        catDAO.ListaCategoria();
                        Console.WriteLine("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 3:
                        catDAO.EditarCategoria();
                        Console.WriteLine("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 4:
                        catDAO.EliminarCategoria();
                        Console.WriteLine("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 5:
                        clienteDAO.ListaClientesTipoDoc();
                        Console.WriteLine("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 0:
                        Console.WriteLine("Gracias por su visita. ");
                        rpta = "N";
                        break;
                    default:
                        Console.WriteLine("Valor ingresado incorrectamete.");
                        Console.WriteLine("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                }
            } while (rpta == "S" || rpta == "s");

        }
    }
}
