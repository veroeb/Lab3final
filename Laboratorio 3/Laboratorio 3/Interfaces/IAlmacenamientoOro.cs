using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Interfaces
{
    interface IAlmacenamientoOro
    {
        int GuardarOro(int g);
        int CapacidadActualOro { get; set; }
        int CapacidadAlmacenamientoOro { get; set; }
    }
}
