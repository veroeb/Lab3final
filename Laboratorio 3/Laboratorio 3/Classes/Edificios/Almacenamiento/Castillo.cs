using Laboratorio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes
{
    public class Castillo : Almacenes, IAlmacenamientoTropas, IAlmacenamientoNegro, IAlmacenamientoRojo, IAlmacenamientoOro
    {
        public Castillo()
        {
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
        public int CapacidadActualOro { get; set; }
        public int CapacidadAlmacenamientoOro { get; set; }
        public int GuardarOro(int g)
        {
            if (CapacidadActualOro + g <= CapacidadAlmacenamientoOro)
            {
                CapacidadActualOro += g;
                return 0;
            }
            else
            {
                int Diisponible = CapacidadAlmacenamientoOro - CapacidadActualOro;

                CapacidadActualOro += Diisponible;
                return g - Diisponible;
            }
        }

        public int GuardarTropa(int t)
        {
            if (CapacidadActualTropa + t <= CapacidadAlmacenamientoTropa)
            {
                CapacidadActualTropa += t;
                return 0;
            }
            else
            {
                int Disponible = CapacidadAlmacenamientoTropa - CapacidadActualTropa;

                CapacidadActualTropa += Disponible;
                return t - Disponible;
            }
        }
    }       
    
}
