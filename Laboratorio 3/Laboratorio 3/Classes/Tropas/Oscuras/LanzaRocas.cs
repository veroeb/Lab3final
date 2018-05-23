using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Oscuras
{
    public class LanzaRocas : TropaOscura
    {
        public LanzaRocas()
        {
            Nombre = "Lanza rocas";
            Nivel = 1;
            Vida = 290;
            Daño = 65;
            Velocidad = 14;
            Espacio = 6;
            ConsumoNegro = 130;
        }
    }
}
