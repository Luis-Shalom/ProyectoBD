using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoEDM.ModeloBD;

namespace ProyectoDAO
{
   public  class CategoriaDAO
    {

        ProyectoEntities2 db = new ProyectoEntities2();


        public bool Agregar(Categoria produc)
        {
            db.Categorias.Add(produc);
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Modificar(Categoria produc)
        {
            db.Entry(produc).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);


        }
        public bool Eliminar(Categoria produc)
        {
            db.Categorias.Remove(produc);
            return db.SaveChanges() > 0 ? true : false;

        }

        public Categoria Buscar(string pCodigo)
        {
            Categoria produc;


            produc = db.Categorias.DefaultIfEmpty(null).FirstOrDefault(c => c.Codigo.Trim()
            == pCodigo.Trim());

            return (produc);
        }


        public List<Categoria> listar()
        {
            return (db.Categorias.ToList());
        }




    }
}
