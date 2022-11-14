using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Datos
{
    public class Archivos
    {
        protected String ruta;

        public bool Guardar(Entidad.Persona contacto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(contacto.ToString());
                sw.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
