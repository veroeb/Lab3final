using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Globo : TropaNormal
    {
        public Globo()
        {
            Nombre = "Globo";
            Nivel = 1;
            Vida = 120;
            Daño = 75;
            Velocidad = 10;
            Espacio = 5;
            ConsumoRojo = 2000;
        }
    }
}
