using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ContactoPersonal : Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{FechaNacimiento.ToShortDateString()}";
        }
        public int CalcularEdad()
        {
            return 0;
        }

    }
}
