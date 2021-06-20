using ConsoleApp4.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //POO

            #region Listas con un tipo de dato
            ClienteBEAN clieBEAN = new ClienteBEAN();
            clieBEAN.Nombre = "Antony";
            clieBEAN.Apellido = "Morales";

            ClienteBEAN clieBEAN2 = new ClienteBEAN() { Nombre= "Paul", Apellido = "Albino" };

            List<ClienteBEAN> listaCliente = new List<ClienteBEAN>();
            listaCliente.Add(clieBEAN);
            listaCliente.Add(clieBEAN2);
            listaCliente.Add(new ClienteBEAN() { Nombre = "Paul", Apellido = "Albino" });

            Console.WriteLine("Lista de Cliente");

            foreach (var item in listaCliente)
            {
                Console.WriteLine(item.Nombre + " "+ item.Apellido);
            }
            #endregion
            /**Console.ReadLine();**/
        }
    }
}
