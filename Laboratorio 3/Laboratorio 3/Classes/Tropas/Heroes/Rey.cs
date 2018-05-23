using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Heroes
{
    public class Rey : Heroe
    {
        public Rey()
        {
            Nombre = "Rey";
            Nivel = 1;
            Vida = 1700;
            Daño = 120;
            Velocidad = 16;
            Espacio = 20;
            PoderEspecial();
        }
    }
}
