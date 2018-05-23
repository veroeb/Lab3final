using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Oscuras
{
    public class Valkiria : TropaOscura
    {
        public Valkiria()
        {
            Nombre = "Valkiria";
            Nivel = 1;
            Vida = 750;
            Daño = 94;
            Velocidad = 24;
            Espacio = 8;
            ConsumoNegro = 70;
        }
    }
}
