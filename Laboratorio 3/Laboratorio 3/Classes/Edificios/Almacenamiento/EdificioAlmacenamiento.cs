using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento
{
    public abstract class EdificioAlmacenamiento : Edificio
    {
        public int CapacidadAlmacenamiento { get; set; }
        public int CapacidadActual { get; set; }

        public int GetActual()
        {
            return CapacidadActual;
        }

        public int Guardar(int c)
        {
            if (CapacidadActual + c <= CapacidadAlmacenamiento)
            {
                CapacidadActual += c;
                return 0;
            }
            else
            {
                int Disponible = CapacidadAlmacenamiento - CapacidadActual;

                CapacidadActual += Disponible;
                return c - Disponible;
            }
        }

        public bool CapacidadLlena()
        {
            if (CapacidadAlmacenamiento == CapacidadActual)
                return true;
            else
                return false;
        }

    }
}
