using Entidad;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioComercial : Archivos
    {
        public RepositorioComercial()
        {
            ruta = "ContactosComerciales.txt";
        }

        public bool Actualizar(string telefono, ContactoComercial contactoViejo, ContactoComercial contacto)
        {
            StreamReader lectura;
            StreamWriter escribir;
            bool encontrado = false;
            string cadena;
            lectura = File.OpenText(ruta);
            escribir = File.CreateText("tmp.txt");
            cadena = lectura.ReadLine();
            string[] campos = new string[5];
            char[] separador = { ';' };
            
            while (cadena != null)
            {
                campos = cadena.Split(separador);
                if (campos[2].Trim().Equals(telefono))
                {
                    encontrado = true;
                    contactoViejo.Id = contacto.Id;
                    contactoViejo.Nombre = contacto.Nombre;
                    contactoViejo.Telefono = contacto.Telefono;
                    contactoViejo.Nit = contacto.Nit;
                    contactoViejo.RazonSocial = contacto.RazonSocial;
                    contactoViejo.Correo = contacto.Correo;
                    //MODIFICAR REGISTRO 
                    escribir.WriteLine(contactoViejo.ToString());
                }
                else
                {
                    escribir.WriteLine(cadena);
                }
                cadena = lectura.ReadLine();
            }
            if (encontrado == false)
            {

                return false;
            }
            lectura.Close();
            escribir.Close();
            File.Delete(ruta);
            File.Move("tmp.txt", ruta);
            return true;
        }

        public bool Eliminar(string telefono)
        {
            StreamReader lectura;
            StreamWriter escribir;
            bool encontrado = false;
            string cadena;
            lectura = File.OpenText(ruta);
            escribir = File.CreateText("tmp.txt");
            cadena = lectura.ReadLine();
            string[] campos = new string[6];
            char[] separador = { ';' };
            while (cadena != null)
            {
                campos = cadena.Split(separador);
                if (campos[2].Trim().Equals(telefono))
                {
                    encontrado = true;
                }
                else
                {
                    escribir.WriteLine(cadena);
                }
                cadena = lectura.ReadLine();
            }
            if (encontrado == false)
            {

                return false;
            }
            lectura.Close();
            escribir.Close();
            File.Delete(ruta);
            File.Move("tmp.txt", "ContactosComerciales.txt");
            return true;
        }
        public List<ContactoComercial> Leer()
        {
            StreamReader srCo = new StreamReader(ruta);
            List<ContactoComercial> list = new List<ContactoComercial>();
            while (!srCo.EndOfStream)
            {
                list.Add(Mappear(srCo.ReadLine()));     
            }
            srCo.Close();
            return list;
        }
        public ContactoComercial Mappear(string linea)
        {
            ContactoComercial contacto =new ContactoComercial();
            contacto.Id = int.Parse(linea.Split(';')[0]);
            contacto.Nombre = linea.Split(';')[1];
            contacto.Telefono= (linea.Split(';')[2]);
            contacto.Nit = (linea.Split(';')[3]);
            contacto.RazonSocial = (linea.Split(';')[4]);
            contacto.Correo = (linea.Split(';')[5]);
            return contacto;
        }
    }
}
