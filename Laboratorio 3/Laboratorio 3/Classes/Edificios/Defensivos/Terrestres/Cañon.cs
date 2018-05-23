using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Terrestres
{
    public class Cañon : EdificioDefensivoTerrestre
    {
        public Cañon()
        {
            Nombre = "Cañón";
            Vida = 470;
            Nivel = 1;
            ConsumoOro = 250;
            CantidadEdificios = 2;
        }
    }
}
