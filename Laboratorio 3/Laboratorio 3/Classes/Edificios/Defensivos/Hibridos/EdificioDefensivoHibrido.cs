using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Hibridos
{
    public abstract class EdificioDefensivoHibrido : EdificioDefensivo
    {
        protected int ConsumoOro { get; set; }
        protected void AtacarTropas()
        {
        }
    }
}
