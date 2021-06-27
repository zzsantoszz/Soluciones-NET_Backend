using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    class ApplicationBDContext : DbContext
    {
        /*DContext sirve para configurar algunas de las caracteristicas que tendra la BD
         *Crear una propiedad DbSet, sera en adelante una tabla en BD
         */
        public ApplicationBDContext() : base("connBD")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
