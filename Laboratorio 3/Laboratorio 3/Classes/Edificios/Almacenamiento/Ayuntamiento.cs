using Laboratorio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento
{
    public class Ayuntamiento : EdificioAlmacenamiento, IAlmacenamientoRojo
    {
        public int CapacidadActualElixirRojo { get; set; }
        public int CapacidadAlmacenamientoElixirRojo { get; set; }

        public Ayuntamiento()
        {
            CantidadEdificios = 1;
            Nombre = "Ayuntamiento";
            Nivel = 1;
            Vida = 5000;
            CapacidadActual = 0;
            CapacidadAlmacenamiento = 2000;
            CapacidadActualElixirRojo = 0;
            CapacidadAlmacenamientoElixirRojo = 2000;
        }

        public int GuardarElixirRojo(int g)
        {
            if (CapacidadActualElixirRojo + g <= CapacidadAlmacenamientoElixirRojo)
            {
                CapacidadActualElixirRojo += g;
                return 0;
            }
            else
            {
                int Disponible = CapacidadAlmacenamientoElixirRojo - CapacidadActualElixirRojo;

                CapacidadActualElixirRojo += Disponible;
                return g - Disponible;
            }
        }

    }
}
