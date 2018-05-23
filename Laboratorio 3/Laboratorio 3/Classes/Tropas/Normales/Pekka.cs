using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Pekka : TropaNormal
    {
        public Pekka()
        {
            Nombre = "Pekka";
            Nivel = 1;
            Vida = 2800;
            Daño = 240;
            Velocidad = 16;
            Espacio = 25;
            ConsumoRojo = 28000;
        }
    }
}
