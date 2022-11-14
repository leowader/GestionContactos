using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Presentacion
{
    public class VistaPersonal
    {
        //Presentacion.Menu menu = new Presentacion.Menu();
        Entidad.ContactoPersonal personal= new ContactoPersonal();//OBJETO DE CONTACTOS PERSONALES
        Logica.ServicioContPersonal objLog=new Logica.ServicioContPersonal();//OBJETO PARA ACCEDER A LAS FUNCIONES DE CONTACTOS PERSONALES
        public int Tamaño { get; set; }
        ArrayList lista= new ArrayList();
        public VistaPersonal()
        {
            lista=new ArrayList();
        }
        public void LeerDatos()
        {
            Console.WriteLine("-----------LEER DATOS DE CONTACTO PERSONAL------------");
            Console.WriteLine("escriba el id : ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba el nombre:");
            String Nombre = Console.ReadLine();
            Console.WriteLine("escriba el telefono: ");
            String Telefono = Console.ReadLine();
            personal = new ContactoPersonal();
            
            objLog.AgregarContacto(personal); //AGREGANDO EL OBJETO A LA LISTA
            //menu.MenuSeguirCreando();

        }
        public void Mostrar()
        {
            Console.WriteLine(" --------LISTA DE CNTACTOS PERSONALES---------");
            Console.WriteLine("ID                  NOMBRE                  TELEFONO");
            //objLog.mos();
            foreach (var item in objLog.MostrarContactos())//FOR EACH PARA MOSTRAR LISTA DE CONTACTOS EN HORIZONTAL
            {
                Console.WriteLine(item.Id + "                  " + item.Nombre + "                    " + item.Telefono);
            }
            Console.ReadKey();
        }
        public void MostrarTel()
        {
            Console.WriteLine(" escriba el numero de telefono del contacto a buscar: ");
            string telefonoBus=Console.ReadLine();
            Entidad.ContactoPersonal encontrado= objLog.MostrarPorT(telefonoBus);
            Console.WriteLine("numero de telefono encontrado: "+encontrado);
        }
        public void Modificar()
        {
            //Entidad.ContactoPersonal contacto = new ContactoPersonal(1, "1", "2");
            Console.WriteLine(" escriba el numero de telefono del contacto a actualizar: ");
            string telefonoBus = Console.ReadLine();
            ContactoPersonal encontrado = objLog.MostrarPorT(telefonoBus);
            Console.WriteLine("numero de telefono encontrado: " + encontrado);
            Console.Write("ACTUALICE LOS DATOS DEL CONTACTO");
            Console.WriteLine("id: ");
            encontrado.Id = int.Parse(Console.ReadLine());
            Console.Write("nombre: ");
            encontrado.Nombre = Console.ReadLine();
            Console.WriteLine("telefono: ");
            encontrado.Telefono = Console.ReadLine();
            objLog.Editar(telefonoBus,encontrado);
        }
        public void Eliminar()
        {
            Console.WriteLine(" escriba el numero de telefono del contacto a eliminar: ");
            string telefonoBus = Console.ReadLine();
            ContactoPersonal encontrado = objLog.MostrarPorT(telefonoBus);
            objLog.Eliminar(telefonoBus);
        }
    }
}
