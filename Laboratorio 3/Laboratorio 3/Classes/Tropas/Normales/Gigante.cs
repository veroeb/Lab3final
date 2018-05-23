using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Gigante : TropaNormal
    {
        public Gigante()
        {
            Nombre = "Gigante";
            Nivel = 1;
            Vida = 300;
            Daño = 22;
            Velocidad = 12;
            Espacio = 5;
            ConsumoRojo = 250;
        }
    }
}
