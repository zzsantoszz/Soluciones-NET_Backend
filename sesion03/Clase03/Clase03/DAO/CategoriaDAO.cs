using Clase03.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.DAO
{
    class CategoriaDAO
    {
        public void ListaCategoria()
        {
            Console.Clear();
            List<tb_Categoria> listaCat = new List<tb_Categoria>();
            List<tb_Cliente> lista2Cat = new List<tb_Cliente>();
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                listaCat = db.tb_Categoria.ToList();
                lista2Cat = db.tb_Cliente.ToList();
            }
            Console.WriteLine("Lista de Categoria: ");
            foreach (var item in listaCat)
            {
                Console.WriteLine(item.idCategoria + "" + item.nombreCategoria);
            }
            Console.WriteLine("Lista de Cliente: ");
            foreach (var item2 in lista2Cat)
            {
                Console.WriteLine(item2.idCliente + "" + item2.nombreCliente);
            }
        }


        public void RegistrarCategoria()
        {
            Console.Clear();
            Console.WriteLine("Lista de Categoria: ");
            string nombreCat = Console.ReadLine();
            tb_Categoria cat = new tb_Categoria { nombreCategoria = nombreCat };
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                db.tb_Categoria.Add(cat);
                db.SaveChanges();
            }
        }

        public void EditarCategoria()
        {
            Console.Clear();
            Console.Write("Ingrese el ID de Categoria a editar: ");
            int idCat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nuevo nombre: ");
            string nombreCat = Console.ReadLine();
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                tb_Categoria cat = db.tb_Categoria.Find(idCat);
                cat.nombreCategoria = nombreCat;
                db.SaveChanges();
                Console.Write("El registro con codigo " + idCat + " se edito correctamente.");
            }
        }

        public void EliminarCategoria()
        {
            Console.Clear();
            Console.Write("Ingrese el ID de Categoria a editar: ");
            int idCat = Convert.ToInt32(Console.ReadLine());
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                db.tb_Categoria.Remove(db.tb_Categoria.Find(idCat));
                db.SaveChanges();
            }
        }
    }
}
