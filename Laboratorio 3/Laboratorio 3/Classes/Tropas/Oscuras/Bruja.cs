using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Oscuras
{
    public class Bruja : TropaOscura
    {
        public Bruja()
        {
            Nombre = "Bruja";
            Nivel = 1;
            Vida = 270;
            Daño = 50;
            Velocidad = 12;
            Espacio = 12;
            ConsumoNegro = 250;
        }
    }
}
