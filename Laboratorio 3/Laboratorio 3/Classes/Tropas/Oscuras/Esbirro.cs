using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Oscuras
{
    public class Esbirro : TropaOscura
    {
        public Esbirro()
        {
            Nombre = "Esbirro";
            Nivel = 1;
            Vida = 20;
            Daño = 30;
            Velocidad = 33;
            Espacio = 2;
            ConsumoNegro = 6;
        }
    }
}
