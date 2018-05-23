using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Oscuras
{
    public class Montapuerco : TropaOscura
    {
        public Montapuerco()
        {
            Nombre = "Montapuerco";
            Nivel = 1;
            Vida = 270;
            Daño = 60;
            Velocidad = 24;
            Espacio = 5;
            ConsumoNegro = 40;
        }
    }
}
