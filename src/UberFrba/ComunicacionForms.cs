using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    interface ComunicacionForms
    {   //uso estos tres porque en un form tenía que recibir ids de los tres, por lo que no tenia manera de diferenciarlos
        void editarChofer(string id);
        void editarCliente(string id);
        void editarAuto(string id);
        // dejé este genérico para los otros casos en que se selecciona un row y es unico en todo el form, como el caso de turno o rol
        void editar(string id);
       
    }
}
