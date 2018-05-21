using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Interfaces
{
    interface IAlmacenamientoTropas
    {
        int GuardarTropa (int g);
        int CapacidadActualTropa { get; set; }
        int CapacidadAlmacenamientoTropa { get; set; }
    }
}
