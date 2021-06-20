using ConsoleApp6_practica02.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_practica02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor2,valor3,valor4;

            #region Diccionary - Diccionario de datos
            //Key - Value
            Dictionary<int, int> datos = new Dictionary<int, int>();


            Console.Write("Ingrese las horas trabajas del dia: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor > 8)
            { valor2 = valor - 8;

                if (valor2 <= 3)
                {
                    valor3 = valor2 * 12;
                }
                else if (valor2 <= 5)
                {
                    valor3 = valor2 * 13;
                }
                else
                {
                    valor3 = valor2 * 15;
                }

                valor4 = valor3 + 80;

                datos.Add(1, valor);
                datos.Add(2, 8);
                datos.Add(3, valor2);
                datos.Add(4, valor3);
                datos.Add(5, valor4);

            }
            else {
                datos.Add(1, 8);
                datos.Add(2, 8);
                datos.Add(3, 0);
                datos.Add(4, 0);
                datos.Add(5, 80);
            }

                Console.WriteLine("RESULTADO:");
                Console.WriteLine("Horas trabajadas:  " + datos[1]);
                Console.WriteLine("Horas normales:  " + datos[2]);
                Console.WriteLine("Horas extras:  " + datos[3]);
                Console.WriteLine("Costo de horas extras:  " + datos[4]);
                Console.WriteLine("Pago total a realizar:  " + datos[5]);
            

            #endregion
            Console.ReadLine();


            /* */





        }
    }
}
