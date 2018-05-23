using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Hibridos
{
    public class TorreMagos : EdificioDefensivoHibrido
    {
        public TorreMagos()
        {
            Nombre = "Torre de magos";
            Nivel = 1;
            Vida = 280;
            ConsumoOro = 180000;
            CantidadEdificios = 2;
        }
    }
}
