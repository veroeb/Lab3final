using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Hibridos
{
    public class TorreInfierno : EdificioDefensivoHibrido
    {
        public TorreInfierno()
        {
            Nombre = "Torre Infierno";
            Nivel = 1;
            Vida = 1500;
            ConsumoOro = 5000000;
            CantidadEdificios = 2;
        }
    }
}
