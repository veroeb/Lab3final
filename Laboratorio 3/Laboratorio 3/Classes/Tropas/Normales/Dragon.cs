using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Dragon : TropaNormal
    {
        public Dragon()
        {
            Nombre = "Dragón";
            Nivel = 1;
            Vida = 1900;
            Daño = 140;
            Velocidad = 16;
            Espacio = 20;
            ConsumoRojo = 25000;
        }
    }
}
