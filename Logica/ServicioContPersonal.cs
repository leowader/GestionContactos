using Datos;
using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Logica
{
    public class ServicioContPersonal : IServicios<ContactoPersonal>

    {
        List<ContactoPersonal> listaPersonal=new List<ContactoPersonal>();
        readonly Datos.RepositorioPersonal miruta1= new RepositorioPersonal() ;
        public ServicioContPersonal()
        {
            listaPersonal = new List<ContactoPersonal>();
        }
        public string AgregarContacto(ContactoPersonal contacto)
        {
            foreach (var item in listaPersonal)
            {

                if (contacto.Telefono.Equals(item.Telefono))
                {
                    return $"el contacto con numero {contacto.Telefono} ya existe";
                }
                else if (contacto.Id.Equals(item.Id))
                {
                    return $"No se permiten numeros de identificacion repeditos ";
                }
            }
            listaPersonal.Add(contacto);
            var estado = miruta1.Guardar(contacto);
            return estado ? $"contacto guardado con Nombre: {contacto.Nombre}": $"Error al guardar el contacto: {contacto.Nombre}";
        }
        public string Editar(string telefono, ContactoPersonal contactoViejo, ContactoPersonal contacto)
        {
            try
            {
                var estado = miruta1.Actualizar(telefono,contactoViejo,contacto);
                return estado ? $"El Contacto:{telefono} ha sido actualizado" : $"El Contacto:{telefono} No ha sido actualizado";
            }
            catch (FormatException Fe)
            {
                Console.WriteLine(Fe.Message);
            }
            return null;
        }

        public string Eliminar(string telefono)
        {
            try
            {
                var estado =miruta1.Eliminar(telefono);
                return estado ? $"El Contacto:{telefono} ha sido eliminado" : $"El Contacto:{telefono} No ha sido eliminado";
            }
            catch (FormatException Fe)
            {
                Console.WriteLine(Fe.Message);
            }
            return null; 
        }
        public List<ContactoPersonal> MostrarContactos()
        {
            try
            {
                listaPersonal = miruta1.Leer();    
            }
            catch (StackOverflowException Se)
            {
                Console.WriteLine(Se.Message);
            }
            catch (System.FormatException Fe)
            {

                Console.WriteLine(Fe.Message);
                
            }
            catch (FileNotFoundException Fe) {
                Console.WriteLine(Fe.Message);
            }
            return listaPersonal;//lista contactos personales
            
        }
        public ContactoPersonal MostrarPorE(int id)
        {

            throw new NotImplementedException();
        }
        public ContactoPersonal MostrarPorT(string telefono)
        {
            foreach (var item in miruta1.Leer())
            {
                ContactoPersonal contactoPersonal = new ContactoPersonal();
                if (item.Telefono==telefono)
                {
                    contactoPersonal = item;
                    return contactoPersonal;
                }
            }
            return null;
        }
        public bool Existe(ContactoPersonal contacto)
        {
            throw new NotImplementedException();
        }
    }
}
