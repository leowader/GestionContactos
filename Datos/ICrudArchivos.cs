using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICrudArchivos<Contacto>
    {
        List<Contacto> Leer();
        bool Actualizar(string telefono, ContactoPersonal contactoViejo, ContactoPersonal contacto);
        Contacto Mappear(string linea);
        bool Eliminar(string telefono);
    }
}
