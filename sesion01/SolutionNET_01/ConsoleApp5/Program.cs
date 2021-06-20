using ConsoleApp5.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Diccionary - Diccionario de datos
            //Key - Value
            Dictionary<int, string> datos = new Dictionary<int, string>();
            datos.Add(1, "Lunes");
            datos.Add(2, "Martes");
            datos.Add(3, "Miercoles");
            datos.Add(4, "Jueves");
            datos.Add(5, "Viernes");
            datos.Add(6, "Sabado");
            datos.Add(7, "Domingo");

            /* que se ingrese los calores entre 1 al 7 y que se muestre el dia de la semana */
            Console.Write("Ingrese valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El nombre del dia es:  " + datos[valor]);

            #endregion
            /**Console.ReadLine();**/
        }
    }
}
