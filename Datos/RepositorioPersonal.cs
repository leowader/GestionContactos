using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPersonal: Archivos,ICrudArchivos<ContactoPersonal>
    {

        public RepositorioPersonal()
        {
            ruta = "ContactosFamiliares.txt";
        }
        public List<ContactoPersonal> Leer()
        {
            StreamReader srPer = new StreamReader(ruta);
            List<Entidad.ContactoPersonal> listaArchivosPer = new List<ContactoPersonal>(); 
            while (!srPer.EndOfStream)
            {
                listaArchivosPer.Add(Mappear(srPer.ReadLine()));
            }
            srPer.Close();
            return listaArchivosPer; 
        }
        public ContactoPersonal Mappear(string linea)
        {
            var contacto = new Entidad.ContactoPersonal
            {
                Id = int.Parse(linea.Split(';')[0]),
                Nombre = (linea.Split(';')[1]),
                Telefono = (linea.Split(';')[2]),
                FechaNacimiento = DateTime.Parse(linea.Split(';')[3])
            };
            return contacto;
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
            string[] campos = new string[4];
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
            File.Move("tmp.txt","ContactosFamiliares.txt");
            return true;
        }
        public bool Actualizar(string telefono,ContactoPersonal contactoViejo,ContactoPersonal contacto)
        {
            StreamReader lectura;
            StreamWriter escribir;
            bool encontrado = false;
            string cadena;
            lectura = File.OpenText(ruta);
            escribir = File.CreateText("tmp.txt");
            cadena = lectura.ReadLine();
            string[] campos = new string[4];
            char[] separador = { ';' };
            //List<Entidad.ContactoPersonal> listaPer = new List<ContactoPersonal>();
            while (cadena != null)
            {
                campos = cadena.Split(separador);
                if (campos[2].Trim().Equals(telefono))
                {
                    encontrado = true;
                    contactoViejo.Id=contacto.Id;
                    contactoViejo.Nombre = contacto.Nombre;
                    contactoViejo.Telefono = contacto.Telefono;
                    contactoViejo.FechaNacimiento=contacto.FechaNacimiento;
                    //MODIFICAR REGISTRO 
                    escribir.WriteLine(contactoViejo.Id+";"+contactoViejo.Nombre+";"+contactoViejo.Telefono+";"+contactoViejo.FechaNacimiento);
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
            File.Move("tmp.txt", "ContactosFamiliares.txt");
            return true;
        }
    }
}
