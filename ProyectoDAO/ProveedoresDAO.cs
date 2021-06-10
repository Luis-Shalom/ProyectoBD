using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoEDM.ModeloBD;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ProyectoDAO
{
   public class ProveedoresDAO
    {
        ProyectoEntities2 db = new ProyectoEntities2();


        public bool Agregar(Proveedor clientecls)
        {
            db.Proveedors.Add(clientecls);
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Modificar(Proveedor clientecls)
        {
            db.Entry(clientecls).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);


        }
        public bool Eliminar(Proveedor clientecls)
        {
            db.Proveedors.Remove(clientecls);
            return db.SaveChanges() > 0 ? true : false;

        }

        public Proveedor Buscar(string pCodigo)
        {
            Proveedor clientecls;


            clientecls = db.Proveedors.DefaultIfEmpty(null).FirstOrDefault(c => c.Codigo.Trim()
            == pCodigo.Trim());

            return (clientecls);
        }


        public List<Cliente> listar()
        {
            return (db.Clientes.ToList());
        }




    }
}
