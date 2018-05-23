using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Oscuras
{
    public class Golem : TropaOscura
    {
        public Golem()
        {
            Nombre = "Golem";
            Nivel = 1;
            Vida = 4500;
            Daño = 38;
            Velocidad = 12;
            Espacio = 30;
            ConsumoNegro = 450;
        }
    }
}
