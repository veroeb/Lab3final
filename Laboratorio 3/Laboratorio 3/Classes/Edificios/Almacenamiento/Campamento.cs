using System;
using System.Collections.Generic;
using System.Linq;
using Laboratorio_3.Classes.Tropas;
using System.Text;
using Laboratorio_3.Classes.Tropas.Normales;
using Laboratorio_3.Classes.Tropas.Oscuras;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes
{
    public class Campamento : Almacenes
    {
        public List<Tropa> tropas;
        public Campamento()
        {
            CapacidadAlmacenamiento = 20;
            CantActual = 0;
            tropas = new List<Tropa>();
        }
        public String AgregarTropaNormal(Tropa t)
        {
            tropas.Add(t);
            CantActual = CantActual - t.Espacio;
            if (CantActual-t.Espacio <= 0)
            {
                tropas.Remove(t);
                return "No hay espacio";
            }
            return "Tropa Agregada Correctamente";
        }       
    }
}
