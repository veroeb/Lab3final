using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Interfaces
{
    interface IAlmacenamientoNegro
    {
        int GuardarElixirNegro(int g);
        int CapacidadActualElixirNegro { get; set; }
        int CapacidadAlmacenamientoElixirNegro { get; set; }
    }
}
