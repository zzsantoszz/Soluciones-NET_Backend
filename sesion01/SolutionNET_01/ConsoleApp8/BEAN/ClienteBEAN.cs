using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.BEAN
{
    public class ClienteBEAN
    {
        //Uso del atajo propfull
        //Uso de atajo prop

        public int codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        private char genero;

        public int num_valor { get; set; }

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Carrera { get; set; }

        public int horas_trabajadas { get; set; }

        public int pago_realizar { get; set; }

        /*Metodos*/

        public string ConactenarDatos()
        {
            string concatenado= "";
            /*Accion segun el metodo*/;
            concatenado = Nombre + ", " + Apellido;
            return concatenado;
        }

        public string ConactenarDatosconParametros(string pNombre, string pApellido)
        {
            string concatenado = "";
            concatenado = pNombre + ", " + Apellido;
            return concatenado;
        }

    }
}
