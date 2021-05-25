using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoEDM;
using System.Data.Entity;
using System.Threading.Tasks;
using ProyectoEDM.ModeloBD;

namespace ProyectoDAO
{
    public class ClienteDAO
    {
        

        ProyectoEntities2 db = new ProyectoEntities2();


        public bool Agregar (Cliente clientecls)
        {
            db.Clientes.Add( clientecls);
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Modificar( Cliente clientecls)
        {
            db.Entry(clientecls).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false); 


        }
        public bool Eliminar(Cliente clientecls)
        {
            db.Clientes.Remove(clientecls);
            return db.SaveChanges() > 0 ? true : false;

        }

        public  Cliente Buscar(string pCodigo)
        {
            Cliente clientecls;


            clientecls = db.Clientes.DefaultIfEmpty(null).FirstOrDefault(c => c.Codigo.Trim()
            ==pCodigo.Trim());

            return (clientecls);
        }






    }
}
