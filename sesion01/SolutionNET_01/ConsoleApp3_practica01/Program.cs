using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_practica01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar un programa que ingrese valores, si es (0) que termine su ejecucion*/
            /* y muestre todos los valores ingresados previamente*/

            int numero;
            List<int> listaNumeros = new List<int>();

            do
            {
                Console.WriteLine("Ingrese numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero != 0)
                { listaNumeros.Add(numero); }
            }
            while (numero != 0);

            Console.WriteLine("Lista de Numeros: ");

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                //indice[0] = 40
                //indice[1] = 9
                Console.Write(listaNumeros[i]+ ", ");
                //Console.WriteLine(listaNumeros[i]);

            }
            Console.ReadLine();
        }
    }
}
