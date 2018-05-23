using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Heroes
{
    public class Warden : Heroe
    {
        public Warden()
        {
            Nombre = "Warden";
            Nivel = 1;
            Vida = 1000;
            Daño = 50;
            Velocidad = 16;
            Espacio = 20;
            PoderEspecial();
        }
    }
}
