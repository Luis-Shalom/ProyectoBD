using ProyectoEDM.ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ProyectoDAO
{
    


    public class TipoClienteDao
    {

        ProyectoEntities2 db = new ProyectoEntities2();


        public bool Agregar(Cliente clientecls)
        {
            db.Clientes.Add(clientecls);
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Modificar(Cliente clientecls)
        {
            db.Entry(clientecls).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);


        }

    }

}
