using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Terrestres
{
    public class Muro : EdificioDefensivoTerrestre
    {
        public Muro()
        {
            Nombre = "Muro";
            Vida = 400;
            Nivel = 1;
            ConsumoOro = 50;
        }
    }
}
