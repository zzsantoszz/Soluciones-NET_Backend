using ConsoleApp1.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            =   -> Asignation
            ==  -> Comparison
             */
            ClienteBEAN clieBEAN = new ClienteBEAN();
            clieBEAN.Nombre = "Antony";
            clieBEAN.Apellido = "Morales";
            clieBEAN.Edad = 29;
            clieBEAN.Genero = 'M';
            clieBEAN.Carrera = "Sistemas";

            ClienteBEAN clieBEAN2 = new ClienteBEAN();
            clieBEAN2.Nombre = "Nombre Cliente 2";
            clieBEAN2.Apellido = "Apellido Cliente 2";

            //ClienteBEAN clieBEAN2 = new ClienteBEAN();
            //clieBEAN2.Nombre = "Marino";
            //clieBEAN2.Apellido = "Ollero";

            //Console.WriteLine("Nombre: " + clieBEAN.Nombre + " " + "Apellido: " + clieBEAN.Apellido);
            //Console.WriteLine("Nombre: " + clieBEAN2.Nombre + " " + "Apellido: " + clieBEAN2.Apellido);

            /**Console.ReadLine();**/

            Console.WriteLine(clieBEAN.ConactenarDatos());
            Console.WriteLine(clieBEAN.ConactenarDatosconParametros("Juan", "Garcia"));
            Console.WriteLine(clieBEAN2.ConactenarDatos());
            Console.WriteLine(clieBEAN2.ConactenarDatosconParametros("Nobre Cliente 3 ", " Apellido Cliente 3 "));
        }
    }
}
