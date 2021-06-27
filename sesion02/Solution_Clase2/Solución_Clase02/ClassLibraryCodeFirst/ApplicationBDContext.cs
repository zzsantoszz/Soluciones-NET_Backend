using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    class ApplicationBDContext :DbContext
    {
        /*DContext sirve para configurar algunas de las caracteristicas que tendra la BD
         *Crear una propiedad DbSet, sera en adelante una tabla en BD
         */
        public ApplicationBDContext() : base("connBD")
        {

        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }

}
