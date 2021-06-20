using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //POO

            #region Listas con un tipo de dato
            /*
                Listas - List
                Diccionario - Dictionary
                Colas - Queue
                Pilas - Stack
             */
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(40); // indice 0
            listaNumeros.Add(9); // indice 1
            listaNumeros.Add(10); // indice 2
            //Inicialización; validación; incremento
            Console.WriteLine("Lista de Números con FOR");
            for (int i = 0; i< listaNumeros.Count; i++)
            {
                //indice[0] = 40
                //indice[1] = 9
                Console.WriteLine(listaNumeros[i]);
            }

            Console.WriteLine("Lista de Números con FOREACH");
            int k = 0;
            foreach (var item in  listaNumeros)
            {

                Console.WriteLine(item);
            }

            #endregion
            /**Console.ReadLine();**/
        }
    }
}
