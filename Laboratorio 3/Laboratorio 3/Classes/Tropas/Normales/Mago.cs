using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Mago : TropaNormal
    {
        public Mago()
        {
            Nombre = "Mago";
            Nivel = 1;
            Vida = 75;
            Daño = 75;
            Velocidad = 16;
            Espacio = 4;
            ConsumoRojo = 1500;
        }
    }
}
