using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento
{
    public class Campamento : EdificioAlmacenamiento
    {
        public Campamento()
        {
            CapacidadAlmacenamiento = 200;
            CapacidadActual = 0;
            CantidadEdificios = 4;
        }
    }
}
