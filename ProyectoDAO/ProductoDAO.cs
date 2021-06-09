using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoEDM.ModeloBD;

namespace ProyectoDAO
{
  public  class ProductoDAO
    {
        ProyectoEntities2 db = new ProyectoEntities2();


        public bool Agregar(Producto produc)
        {
            db.Productoes.Add(produc);
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Modificar(Producto produc)
        {
            db.Entry(produc).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);


        }
        public bool Eliminar(Producto produc)
        {
            db.Productoes.Remove(produc);
            return db.SaveChanges() > 0 ? true : false;

        }

        public Producto Buscar(string pCodigo)
        {
            Producto produc;


            produc = db.Productoes.DefaultIfEmpty(null).FirstOrDefault(c => c.Codigo.Trim()
            == pCodigo.Trim());

            return (produc);
        }


        public List<Producto> listar()
        {
            return (db.Productoes.ToList());
        }





    }
}
