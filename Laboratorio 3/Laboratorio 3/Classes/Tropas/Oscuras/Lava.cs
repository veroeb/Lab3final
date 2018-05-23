using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Oscuras
{
    public class Lava : TropaOscura
    {
        public Lava()
        {
            Nombre = "Lava";
            Nivel = 1;
            Vida = 5700;
            Daño = 10;
            Velocidad = 12;
            Espacio = 30;
            ConsumoNegro = 390;
        }
    }
}
