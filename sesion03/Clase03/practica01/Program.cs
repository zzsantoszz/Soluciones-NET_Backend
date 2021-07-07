using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica01.BEAN;
using practica01.DAO;
using practica01.Modelo;

namespace practica01
{
    class Program
    {
        static void Main(string[] args)
        {

            ContactibilidadDAO contactabilidadDAO = new ContactibilidadDAO();
            ColaboradorDAO colaboradoresDAO = new ColaboradorDAO();
            ClienteDAO clientesDAO = new ClienteDAO();
            ProductoDAO productosDAO = new ProductoDAO();
            string rpta = "N";
            int codMenu = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al mantenimiento de Categoria");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("1- Listar Contactabilidad.");
                Console.WriteLine("2- Registrar.");
                Console.WriteLine("\n0- Salir.");
                Console.WriteLine("Ingrese el codigo del menu: ");
                codMenu = Convert.ToInt32(Console.ReadLine());
                switch (codMenu)
                {
                    case 1:
                        contactabilidadDAO.ListaContactibilidad();
                        Console.WriteLine("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 2:
                        //catDAO.RegistrarCategoria();
                        //catDAO.ListaCategoria();
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
