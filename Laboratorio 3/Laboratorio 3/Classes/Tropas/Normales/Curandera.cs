using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Curandera : TropaNormal
    {
        public Curandera()
        {
            Nombre = "Curandera";
            Nivel = 1;
            Vida = 500;
            Daño = 24;
            Velocidad = 16;
            Espacio = 14;
            ConsumoRojo = 5000;
        }
    }
}
