using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Definiciones
{
    public interface ISeparadorDeLineasExtraidas
    {
        List<String[]> obtenerArrayEventoFecha(List<String> arrayLineasExtraidas);
    }
}
