using ConsoleApp8.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            ClienteBEAN clieBEAN = new ClienteBEAN();
            List<ClienteBEAN> listaCliente = new List<ClienteBEAN>();

            Dictionary<int, int> listaCostoExtra = new Dictionary<int, int>();
            listaCostoExtra.Add(0, 10);
            listaCostoExtra.Add(1, 12);
            listaCostoExtra.Add(2, 12);
            listaCostoExtra.Add(3, 12);
            listaCostoExtra.Add(4, 13);
            listaCostoExtra.Add(5, 13);
            listaCostoExtra.Add(6, 15);
            listaCostoExtra.Add(7, 15);
            listaCostoExtra.Add(8, 15);

            Console.Write("Cuantos trabajadores va ingresar: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<cantidad ;i++)
            {


                Console.Write("Ingresar codigo: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese horas trabajadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            int horaExtra = 0;
            int costoHoraExtra = 0;
            int costodia = 0;


                if (horas > 8)
            {
                horaExtra = horas - 8;
                costoHoraExtra = listaCostoExtra[horaExtra] * horaExtra;
                costodia = 8 * listaCostoExtra[0];
            }
            else
            {
                costodia = horas * listaCostoExtra[0];
            }

                //Console.WriteLine("Horas trabajadas:  " + horas + "S/. ");
                //Console.WriteLine("Costo horas normales:  " + costodia + "S/. ");
                //Console.WriteLine("Horas Extras:  " + horaExtra);
                //Console.WriteLine("Costo horas extras:  " + costoHoraExtra + "S/. ");
                //Console.WriteLine("--------------------");
                //Console.WriteLine("Pago a realizar es de:  " + (costodia + costoHoraExtra) + "S/. ");

                clieBEAN.codigo = codigo;
                clieBEAN.Nombre = nombre;
                clieBEAN.horas_trabajadas = horas;
                clieBEAN.pago_realizar = (costodia + costoHoraExtra);
                listaCliente.Add(clieBEAN);



            }
            /*
             
             */
            Console.WriteLine("RESUMEN: ");
            foreach (var item in listaCliente)
            {
                Console.WriteLine("Codigo: " + item.codigo + " " + "Nombre: " + item.Nombre + " " + "Horas trabajadas: " + item.horas_trabajadas + " " + "Pagos a realizar: " + item.pago_realizar);
            }

        }
    }
}
