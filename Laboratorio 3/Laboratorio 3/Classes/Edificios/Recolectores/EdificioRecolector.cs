using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Recolectores
{
    public abstract class EdificioRecolector : Edificio
    {
        public int ProduccionPorSegundo { get; set; }
    }
}
