using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Duende : TropaNormal
    {
        public Duende()
        {
            Nombre = "Duende";
            Nivel = 1;
            Vida = 25;
            Daño = 11;
            Velocidad = 32;
            Espacio = 1;
            ConsumoRojo = 25;
        }
    }
}
