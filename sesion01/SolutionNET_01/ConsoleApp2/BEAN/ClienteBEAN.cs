using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BEAN
{
    public class ClienteBEAN
    {
        //Uso del atajo propfull
        //Uso de atajo prop

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        private char genero;

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Carrera { get; set; }

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
