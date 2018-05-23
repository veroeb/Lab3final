using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Heroes
{
    public abstract class Heroe : Tropa
    {
        protected void PoderEspecial()
        {
            Daño += 100;
            Vida += 50;
            Velocidad += 30;
            Nivel++;
        }
    }
}
