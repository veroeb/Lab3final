using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Hibridos
{
    public class TorreTesla : EdificioDefensivoHibrido
    {
        public TorreTesla()
        {
            Nombre = "Torre de tesla";
            Nivel = 1;
            Vida = 280;
            ConsumoOro = 1000000;
            CantidadEdificios = 2;
        }
    }
}
