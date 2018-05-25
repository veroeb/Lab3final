using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio_3.Classes.Edificios.Almacenamiento;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
using Laboratorio_3.Classes.Tropas;
using Laboratorio_3.Classes.Tropas.Normales;
using Laboratorio_3.Classes.Tropas.Oscuras;

namespace Laboratorio_3.Classes.Edificios.Cuarteles
{
    public abstract class Cuarteles : Edificio
    {
        public abstract Tropa GenerarTropa(String nombreTropa);
    }
}
