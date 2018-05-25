using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes
{
    public abstract class Almacenes : Componente
    {
        public int CapacidadAlmacenamiento { get; set; }
        public int CantActual { get; set; }

        public int GetActual()
        {
            return CantActual;
        }

        public int Guardar(int c)
        {
            if (CantActual + c <= CapacidadAlmacenamiento)
            {
                CantActual += c;
                return 0;
            }
            else
            {
                int disponible = CapacidadAlmacenamiento - CantActual;
                CantActual += disponible;
                return c - disponible;
            }
        }

        public Boolean Lleno()
        {
            if (CapacidadAlmacenamiento == CantActual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

