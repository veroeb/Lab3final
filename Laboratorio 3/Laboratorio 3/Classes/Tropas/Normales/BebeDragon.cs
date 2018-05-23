using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class BebeDragon : TropaNormal
    {
        public BebeDragon()
        {
            Nombre = "Dragón bebé";
            Nivel = 1;
            Vida = 1900;
            Daño = 75;
            Velocidad = 16;
            Espacio = 10;
            ConsumoRojo = 15000;
        }
    }
}
