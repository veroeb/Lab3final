using Laboratorio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes
{
    public class Ayuntamiento:Almacenes,IAlmacenamientoRojo,IAlmacenamientoOro
    {
        public int CapacidadActualElixirRojo { get; set; }
        public int CapacidadAlmacenamientoElixirRojo { get; set; }
        public int CapacidadActualOro { get; set; }
        public int CapacidadAlmacenamientoOro { get; set; }

        public Ayuntamiento()
        {
            
            Nombre = "Ayuntamiento";
            Nivel = 1;
            Vida = 5000;
            CapacidadActualOro = 0;
            CapacidadActualElixirRojo = 0;
            CapacidadAlmacenamientoOro = 2000;
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

        public int GuardarOro(int g)
        {
            if(CapacidadActualOro + g <= CapacidadAlmacenamientoOro)
            {
                CapacidadActualOro += g;
                return 0;
            }
            else
            {
                int disponible = CapacidadAlmacenamientoOro - CapacidadActualOro;
                CapacidadActualOro += disponible;
                return g - disponible;
            }
        }
    }
}
