using Laboratorio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento
{
    public class Castillo : EdificioAlmacenamiento, IAlmacenamientoTropas, IAlmacenamientoNegro, IAlmacenamientoRojo
    {
        public Castillo()
        {
            CantidadEdificios = 1;
            Nombre = "Castillo";
            Nivel = 1;
            Vida = 5000;
        }

        public int CapacidadActualElixirRojo { get; set; }
        public int CapacidadAlmacenamientoElixirRojo { get; set; }
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

        public int CapacidadActualElixirNegro { get; set; }
        public int CapacidadAlmacenamientoElixirNegro { get; set; }
        public int GuardarElixirNegro(int g)
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

        public int CapacidadActualTropa { get; set; }
        public int CapacidadAlmacenamientoTropa { get; set; }
        public int GuardarTropa(int g)
        {
            return 0;
        }
    }
}
