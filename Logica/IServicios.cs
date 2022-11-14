using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IServicios<Tipo>
    {
        string AgregarContacto(Tipo contacto);
        string Eliminar(string telefono);
        List<Tipo>  MostrarContactos();
        Tipo MostrarPorE(int id);
        Tipo MostrarPorT(string telefono);
        bool Existe(Tipo contacto);
        string Editar(String telefono, Tipo contactoViejo, Tipo contacto);
    }
}
