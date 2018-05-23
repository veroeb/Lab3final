using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Heroes
{
    public class Reina : Heroe
    {
        public Reina()
        {
            Nombre = "Reina";
            Nivel = 1;
            Vida = 725;
            Daño = 160;
            Velocidad = 24;
            Espacio = 20;
            PoderEspecial();
        }
    }
}
