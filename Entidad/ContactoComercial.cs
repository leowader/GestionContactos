using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ContactoComercial: Persona
    {
        public String Nit { get; set; }
        public  String RazonSocial { get; set; }
        public String Correo { get; set; }
        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{Nit};{RazonSocial};{Correo}";
        }
    }
}
