using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Barbaro : TropaNormal
    {
        public Barbaro()
        {
            Nombre = "Bárbaro";
            Nivel = 1;
            Vida = 45;
            Daño = 8;
            Velocidad = 20;
            Espacio = 1;
            ConsumoRojo = 25;
        }
    }
}
