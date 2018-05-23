using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Minero : TropaNormal
    {
        public Minero()
        {
            Nombre = "Minero";
            Nivel = 1;
            Vida = 550;
            Daño = 80;
            Velocidad = 24;
            Espacio = 6;
            ConsumoRojo = 4200;
        }
    }
}
