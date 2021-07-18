using Clase04_ejercicio02.BEAN;
using Clase04_ejercicio02.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04_ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta = "N";

            do
            {
                RolDAO rolDAO = new RolDAO();
                Console.Clear();
                Console.WriteLine("Mantenimiento de Roles");
                Console.WriteLine("1. Lista de Roles ADO .NET.");
                Console.WriteLine("5. Lista de Roles EF.");
                Console.WriteLine("2. Registro Roles.");
                Console.WriteLine("3. Registro y Listado de Roles.");
                Console.WriteLine("4. Buscar por ID.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("\nIngrese Opcion: ");
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        List<RolBEAN> ListaRol = new List<RolBEAN>();
                        ListaRol = rolDAO.ListaRoles();
                        Console.Clear();
                        Console.WriteLine("Lista Roles");
                        foreach (var item in ListaRol)
                        {
                            Console.WriteLine(item.IdRol + "\t" + item.NombreRol);
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 2:
                        RolBEAN rolBEAN = new RolBEAN();
                        Console.Write("Ingrese nombre de Rol: ");
                        rolBEAN.NombreRol = Console.ReadLine();
                        bool rptaReg = rolDAO.RegistrarRol(rolBEAN);
                        if (rptaReg)// if(rptaReg==true)
                        {
                            Console.WriteLine("Registrado Correctamente.");
                        }
                        else {
                            Console.WriteLine("Errir en registro de Rol");
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 3:
                        RolBEAN rolBEAN2 = new RolBEAN();
                        Console.Write("Ingrese nombre de Rol: ");
                        rolBEAN2.NombreRol = Console.ReadLine();
                        List<RolBEAN> listaRol = rolDAO.RegistroListaRoles(rolBEAN2);
                        foreach (var item in listaRol)
                        {
                            Console.WriteLine(item.IdRol + "\t" + item.NombreRol);
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Ingrese ID de Rol a buscar: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        RolBEAN rolBEAN3 = new RolBEAN();
                        rolBEAN3 = rolDAO.BuscarRolID(id);
                        if (rolBEAN3.IdRol == 0)
                        {
                            Console.WriteLine("Los registros con el Id en mencion no existen. ");
                        }
                        else { 
                        Console.WriteLine(rolBEAN3.IdRol + "  " + rolBEAN3.NombreRol);
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    default:
                        break;
                    case 5:
                        using (var db = new connBD_CONTACTABILIDAD())
                        {
                            List<tb_Rol> listaRoles = db.tb_Rol.ToList();
                            foreach (var item in listaRoles)
                            {
                                Console.WriteLine(item.idRol + "\t" + item.nombreRol);
                            }
 
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                }

            } while (rpta == "S" || rpta == "s");

        }
    }
}
