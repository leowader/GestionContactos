using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContComercial : IServicios<ContactoComercial>
    {
        List<ContactoComercial> listaComercial = new List<ContactoComercial>();
        readonly Datos.RepositorioComercial miruta1 = new RepositorioComercial();
        public ServicioContComercial()
        {
            listaComercial = new List<ContactoComercial>();
        }
        public string AgregarContacto(ContactoComercial contacto)
        {
            foreach (var item in listaComercial)
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
            listaComercial.Add(contacto);
            var estado = miruta1.Guardar(contacto);
            return estado ? $"contacto guardado con Nombre: {contacto.Nombre}" : $"Error al guardar el contacto: {contacto.Nombre}";
        }
        public string Editar(string telefono,ContactoComercial contactoViejo, ContactoComercial contacto)
        {
            try
            {
                var estado = miruta1.Actualizar(telefono, contactoViejo, contacto);
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
                var estado = miruta1.Eliminar(telefono);
                return estado ? $"El Contacto:{telefono} ha sido eliminado" : $"El Contacto:{telefono} No ha sido eliminado";
            }
            catch (FormatException Fe)
            {
                Console.WriteLine(Fe.Message);
            }
            return null;
        }
        public bool Existe(ContactoComercial contacto)
        {
            throw new NotImplementedException();
        }

        public List<ContactoComercial> MostrarContactos()
        {
            try
            {
                listaComercial = miruta1.Leer();
            }
            catch (StackOverflowException Se)
            {
                Console.WriteLine(Se.Message);
            }
            catch (System.FormatException Fe)
            {

                Console.WriteLine(Fe.Message);

            }
            catch (FileNotFoundException Fe)
            {
                Console.WriteLine(Fe.Message);
            }
            return listaComercial;
        }

        public ContactoComercial MostrarPorE(int id)
        {
            throw new NotImplementedException();
        }

        public ContactoComercial MostrarPorT(string telefono)
        {
            foreach (var item in miruta1.Leer())
            {
                ContactoComercial contactoComercial = new ContactoComercial();
                if (item.Telefono == telefono)
                {
                    contactoComercial = item;
                    return contactoComercial;
                }
            }
            return null;
        }
    }
}
