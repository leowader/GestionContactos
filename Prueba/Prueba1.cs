using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Prueba1
    {
        Datos.RepositorioPersonal repositorioPersonal = new Datos.RepositorioPersonal();
        public void pruebavol2()
        {
            Logica.ServicioContPersonal servicioContPersonal = new Logica.ServicioContPersonal();
            /*Entidad.ContactoPersonal per1 = new Entidad.ContactoPersonal(1066268141, "leonardo", "3022575805", "7/09/2022");
            per1.mostrar();*/
            Entidad.ContactoPersonal per1 = new ContactoPersonal(12121, "juancamilo", "3025709");
            
            Console.WriteLine(repositorioPersonal.Guardar(per1));

            most();
            Console.ReadKey();
        }
        public void most()
        {
            Console.WriteLine("id             " + "nombre                     " + "telefono");
            foreach (var item in repositorioPersonal.Leer())
            {

                Console.WriteLine(item.Id+"          "+item.Nombre+ "         "+item.Telefono);
            }
        }
        
    }
}
